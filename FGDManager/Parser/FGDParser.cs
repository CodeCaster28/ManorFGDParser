namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Channels;

    public class FGDParser
    {
        private enum ParseMode
        {
            Header,
            KeyValues,
            Choices
        }
        
        private readonly EntityParser entityParser;
        
        private List<Entity> entities = new List<Entity>();
        private Entity currentEntity;
        private KeyValue currentKeyvalue;
        private string[] gameDefinition;
        private ParseMode parseMode;
        
        public FGDParser()
        {
            entityParser = new EntityParser();
        }

        public List<Entity> Parse(string[] gameDef)
        {
            gameDefinition = gameDef;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("-------------- Parsing Entities from FGD: --------------------");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < gameDefinition.Length; i++)
            {
                if (parseMode == ParseMode.Header)
                    SearchHeader(ref i);
                else if (parseMode == ParseMode.KeyValues)
                    SearchKeyValue(i);
                else if (parseMode == ParseMode.Choices)
                    SearchChoices(i);
            }
            Console.WriteLine("--------------------------------------------------------------");
            return entities;
        }

        private string GetWithoutComments(string line)
        {
            line = line.Replace("\t", string.Empty);
            var commentIndex = line.IndexOf("//");
            if (commentIndex >= 0)
            {
                line = line.Remove(line.IndexOf("//"));
            }

            return line;
        }
        
        private void SearchHeader(ref int lineIndex)
        {
            var line = GetWithoutComments(gameDefinition[lineIndex]);
            if (!line.StartsWith("@"))
                return;

            entityParser.ParseEntity(line, out var entity);
            entity.InheritedKeyValues.AddRange(GetBaseKeyValues(entity.BaseClasses, entity));

            entities.Add(entity);
            currentEntity = entity;
            
            if (!line.EndsWith("[]"))
            {
                // Skip [ under header
                lineIndex++;
                parseMode = ParseMode.KeyValues;
            }
        }
        
        private List<KeyValue> GetBaseKeyValues(List<string> baseClasses, Entity entity)
        {
            var inheritedKeys = new List<KeyValue>();

            foreach (var baseClass in baseClasses)
            {
                var baseEntity = entities.FirstOrDefault(a => a.ClassName == baseClass);
                if (baseEntity == null)
                {
                    Console.WriteLine($@"Base class not found: {baseClass}!");
                }
                else
                {
                    inheritedKeys.AddRange(GetBaseKeyValues(baseEntity.BaseClasses, entity));
                    inheritedKeys.AddRange(baseEntity.KeyValues);
                    
                    var spawnFlags = baseEntity.KeyValues.FirstOrDefault(x => x.Name == "spawnflags");
                    if (spawnFlags != null)
                    {
                        foreach (var choice in spawnFlags.Choices)
                        {
                            entity.RegisterSpawnFlag(choice);
                        }
                    }
                }

            }
            return inheritedKeys;
        }
        
        private void SearchKeyValue(int lineIndex)
        {
            var line = GetWithoutComments(gameDefinition[lineIndex]);
            if (string.IsNullOrWhiteSpace(line))
            {
                return;
            }
            
            if (line.StartsWith("["))
            {
                parseMode = ParseMode.Choices;
            }
            else if (line.StartsWith("]"))
            {
                parseMode = ParseMode.Header;
            }
            else
            {
                currentKeyvalue = entityParser.ParseKeyValue(line, ref currentEntity);
            }
        }

        private void SearchChoices(int lineIndex)
        {
            var line = GetWithoutComments(gameDefinition[lineIndex]);
            if (string.IsNullOrWhiteSpace(line))
            {
                return;
            }

            if (line.StartsWith("]"))
            {
                parseMode = ParseMode.KeyValues;
            }
            else
            {
                var choice = entityParser.ParseChoice(line, ref currentKeyvalue);
            }
        }
    }
}