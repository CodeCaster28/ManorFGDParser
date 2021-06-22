namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing.Printing;
    using System.IO;
    using Json;

    public class GameDefinitionLoader
    {
        private readonly FGDParser fgdParser;
        private readonly MDOutput mdutput;
        private readonly SpecsProvider specsProvider;
        private readonly SpecsGenerator specsGenerator;
        private List<Entity> entities;
        private bool parsed;
        
        public GameDefinitionLoader()
        {
            fgdParser = new FGDParser();
            mdutput = new MDOutput();
            specsProvider = new SpecsProvider();
            specsGenerator = new SpecsGenerator();
        }
        
        public void Parse()
        {
            var gameDefinition = LoadFile();
            entities = fgdParser.Parse(gameDefinition);
            parsed = true;
        }

        public void GenerateOutput()
        {
            if (!parsed)
                Parse();
            
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------- Generating MD output with Json specs: --------------");
            Console.WriteLine("--------------------------------------------------------------");
            specsProvider.Provide(ref entities);
            mdutput.GenerateOutput(entities);
            Console.WriteLine("--------------------------------------------------------------");
        }

        public void GenerateJsons()
        {
            if (!parsed)
                Parse();
            
            specsGenerator.GenerateJsons(entities);
        }

        private static string[] LoadFile()
        {
            var path = "sven-coop.fgd";
            
            if (File.Exists(path))
                return File.ReadAllLines(path);
            
            Console.WriteLine($@"File not found!");
            return null;
        }
    }
}