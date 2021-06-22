namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class EntityParser
    {
        public void ParseEntity(string header, out Entity entity)
        {
            var pointer = 0;
            var entityType = GetType(header, ref pointer);
            var baseClasses = GetBaseClasses(header);
                
            pointer = header.IndexOf("=");

            var className = GetClassName(header, ref pointer);
            var docName = string.Empty;
            var messagePrint = $"@{entityType} = [{className}]";
            
            entity = new Entity()
            {
                Type = entityType,
                ClassName = className,
                DocName = docName
            };
            
            if (baseClasses != null)
            {
                entity.BaseClasses = baseClasses;
                messagePrint = messagePrint + " (";

                for (var i = 0; i < baseClasses.Count; i++)
                {
                    messagePrint = messagePrint + $"{baseClasses[i]}";
                    
                    if (i < baseClasses.Count - 1)
                        messagePrint = messagePrint + "+";
                }
                
                messagePrint = messagePrint + ")";
            }
            
            if (TryGetDocName(header, ref pointer, out docName))
            {
                entity.DocName = docName;
                messagePrint = messagePrint + $" [{docName}]";
            }

            Console.WriteLine(messagePrint);
        }

        private EntityType GetType(string header, ref int pointer)
        {
            var typeName = header.SubstringViableFromPointer(ref pointer);
            
            switch (typeName)
            {
                case var _ when typeName.Equals("@BaseClass"):
                    return EntityType.Base;
                case var _ when typeName.Equals("@PointClass"):
                    return EntityType.Point;
                case var _ when typeName.Equals("@SolidClass"):
                    return EntityType.Solid;
                default: return EntityType.Unknown;
            }
        }

        private List<string> GetBaseClasses(string header)
        {
            var regex = new Regex(@"base\((.+?)\)");
            var match = regex.Match(header);
            if (match.Success)
            {
                var parameters = match.Groups[1].Value;
                parameters = parameters.Replace(" ", string.Empty);
                return parameters.Split(',').ToList();
            }

            return null;
        }
        
        private string GetClassName(string header, ref int pointer)
        {
            return header.SubstringViableFromPointer(ref pointer);
        }

        private bool TryGetDocName(string header, ref int pointer, out string docName)
        {
            docName = string.Empty;
            
            if (pointer >= header.Length - 1)
                return false;
            
            pointer++;
            
            docName = header.SubstringViableQuotedFromPointer(ref pointer);
            return docName != string.Empty;
        }

        public KeyValue ParseKeyValue(string keyValue, ref Entity entity)
        {
            var key = new KeyValue(entity);
            var regex = new Regex(@"^(.*?)\(");
            var match = regex.Match(keyValue);
            if (match.Success)
            {
                key.Name = match.Groups[1].Value;
            }
                
            regex = new Regex(@"\((.+?)\)");
            match = regex.Match(keyValue);
            if (match.Success)
            {
                key.Type = match.Groups[1].Value;
            }
            
            regex = new Regex(":.*?\"(.*?)\"");
            match = regex.Match(keyValue);
            if (match.Success)
            {
                key.DocName = match.Groups[1].Value;
            }

            entity.KeyValues.Add(key);
            Console.WriteLine($"    {key.Name}({key.Type})[{key.DocName}]");

            return key;
        }

        public Choice ParseChoice(string line, ref KeyValue keyValue)
        {
            var choice = new Choice();
            var regex = new Regex(":.*?\"(.*?)\"");
            var match = regex.Match(line);
            
            if (match.Success)
            {
                choice.DocName = match.Groups[1].Value;
            }
            
            regex = new Regex("^(.+?):");
            match = regex.Match(line);
            if (match.Success)
            {
                choice.Value = match.Groups[1].Value;
            }
                
            keyValue.Choices.Add(choice);
            
            if (keyValue.Name == "spawnflags")
            {
                keyValue.ParentEntity.RegisterSpawnFlag(choice);
            }
            return choice;
        }
    }
}