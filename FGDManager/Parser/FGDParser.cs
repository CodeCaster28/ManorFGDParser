namespace FGDManager
{
    using System;
    using System.Collections.Generic;

    public class FGDParser
    {
        private readonly EntityParser entityParser;
        
        private List<Entity> entities = new List<Entity>();
        private string[] gameDefiniotion;
        private ParserMode parserMode = ParserMode.Header;
        
        public FGDParser()
        {
            entityParser = new EntityParser();
        }

        public List<Entity> Parse(string[] gameDefinition)
        {
            gameDefiniotion = gameDefinition;
            foreach (var line in gameDefinition)
            {
                var entry = GetWithoutComments(line);
                
                switch (parserMode)
                {
                    case ParserMode.Header:
                        SearchHeader(entry);
                        break;
                    //case ParserMode.Header:
                    //    break;
                    default: continue;
                }
            }

            return entities;
        }

        private string GetWithoutComments(string line)
        {
            var commentIndex = line.IndexOf("//");
            if (commentIndex >= 0)
                line = line.Remove(line.IndexOf("//"));

            return line;
        }
        
        private void SearchHeader(string line)
        {
            if (!line.StartsWith("@"))
                return;

            if (entityParser.ParseEntity(line, out var entity))
            {
                entities.Add(entity);
            }
        }
    }
}