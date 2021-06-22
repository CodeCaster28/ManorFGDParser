namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    public class SpecsGenerator
    {
        public void GenerateJsons(List<Entity> entities)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("---------- Generating empty jsons based on FGD ---------------");
            Console.WriteLine("--------------------------------------------------------------");
            var dir = "entspecs";
            if (Directory.Exists(dir))
            {
                Console.WriteLine("Specs already exists, delete folder before generating new ones");
                Console.WriteLine("--------------------------------------------------------------");
                
                return;
            }
            
            Directory.CreateDirectory(dir);
            
            foreach (var entity in entities)
            {
                var fileName = string.Format("{0}\\{1}.json", dir, entity.ClassName);
                var emptySpec = new SpecsData();
                emptySpec.Classname = entity.ClassName;
                emptySpec.Description = "Entity_Description_here";
                foreach (var key in entity.KeyValues)
                {
                    var choices = new List<SpecsData.ChoiceDescription>();
                    foreach (var choiceEntry in key.Choices)
                    {
                        var choice = new SpecsData.ChoiceDescription {choiceDescription = "Choice_Description_here", choiceValue = choiceEntry.Value};
                        choices.Add(choice);
                    }

                    emptySpec.AddKey(key.Name, "Keyvalue_Description_here", choices);
                }
                emptySpec.Notes.Add("Insert additional notes here");
                emptySpec.Issues.Add("Insert known issues here");
                var output = JsonConvert.SerializeObject(emptySpec, Formatting.Indented);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(output);
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}