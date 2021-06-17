namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing.Printing;
    using System.IO;
    using System.Text;

    public class GameDefinitionLoader
    {
        private readonly FGDParser fgdParser;
        private readonly MDOutput mdutput;

        public GameDefinitionLoader()
        {
            fgdParser = new FGDParser();
            mdutput = new MDOutput();
        }
        
        public void Run()
        {
            var gameDefinition = LoadFile();
            var entities = fgdParser.Parse(gameDefinition);
            mdutput.GenerateOutput(entities);
        }

        private static string[] LoadFile()
        {
            var path = "sven-coop.fgd";
            
            if (File.Exists(path))
                return File.ReadAllLines(path);
            
            Console.WriteLine($"File not found!");
            return null;
        }
    }
}