namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Sockets;
    using Json;
    using Newtonsoft.Json;

    public class SpecsProvider
    {
        private List<SpecsData> Specs { get; set; } = new List<SpecsData>();

        public void Provide(ref List<Entity> entities)
        {
            LoadSpecs(entities.Select(a => a.ClassName).ToList());
            foreach (var entity in entities)
            {
                var result = Specs.FirstOrDefault(a => a.Classname == entity.ClassName);
                if (result != null)
                {
                    entity.Description = result.Description;
                    foreach (var key in entity.KeyValues)
                    {
                        key.Description = result.GetKeyDescription(key.Name);
                        key.Media = result.GetKeyMedia(key.Name);
                        foreach (var choice in key.Choices)
                        {
                            var description = result.GetChoiceDescription(key.Name, choice.Value);
                            var media = result.GetChoiceMedia(key.Name, choice.Value);
                            choice.Description = description;
                            choice.Media = media;
                        }
                    }
                    entity.RefreshFlagsDescriptions();
                    entity.Issues = result.Issues;
                    entity.Notes = result.Notes;
                }
            }
        }

        private void LoadSpecs(List<string> entNames)
        {
            foreach (var entity in entNames)
            {
                var data = LoadData(entity);
                if (data == null)
                {
                    continue;
                }
                data.Classname = entity;
                Specs.Add(data);
            }
        }
        
        private static SpecsData LoadData(string entityName)
        {
            var path = $"entspecs/{entityName}.json";

            if (File.Exists(path))
            {
                var lines = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<SpecsData>(lines);
                return data;
            }
            
            Console.WriteLine($@"Specs not found for entity: {entityName}");
            return null;
        }
    }
}