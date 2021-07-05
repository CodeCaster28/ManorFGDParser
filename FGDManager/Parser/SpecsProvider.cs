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

                    if (entity.Type != EntityType.Base)
                    {
                        foreach (var key in entity.InheritedKeyValues)
                        {
                            if (key.Name == "spawnflags")
                                continue;
                            
                            var overridenDesc = result.GetKeyDescription(key.Name);
                            if (!string.IsNullOrEmpty(overridenDesc))
                            {
                                /*if (entity.KeysDescriptionsOverride.ContainsKey(key.Name))
                                {
                                    Console.WriteLine("Entity " + entity.ClassName + " key exists -> " + key.Name);
                                    entity.KeysDescriptionsOverride[key.Name] = overridenDesc;
                                }
                                else
                                {*/
                                    entity.KeysDescriptionsOverride.Add(key.Name, overridenDesc);
                                //}
                            }
                            // No time to check other overrides as it won't be used anyway
                            //key.Media = result.GetKeyMedia(key.Name);
                            /*foreach (var choice in key.Choices)
                            {
                                var description = result.GetChoiceDescription(key.Name, choice.Value);
                                var media = result.GetChoiceMedia(key.Name, choice.Value);
                                choice.Description = description;
                                choice.Media = media;
                            }*/
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
                Console.WriteLine("Getting SpecsData for " + entity);
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