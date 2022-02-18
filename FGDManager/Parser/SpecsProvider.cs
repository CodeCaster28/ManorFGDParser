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

        private List<Entity> allEntities; 
        
        public void Provide(ref List<Entity> entities) 
        {
            allEntities = entities;
            LoadSpecs(entities.Select(a => a.ClassName).ToList());
            foreach (var entity in entities) 
            {
                if (entity.Type == EntityType.Base)
                    continue;
                
                entity.CreateFinalKeyValues();
                
                var doc = GetDocumentation(entity);
                entity.Description = doc.Description;
                
                foreach (var key in entity.FinalKeyValues)
                {
                    key.Description = doc.GetKeyDescription(key.Name);
                    key.Media = doc.GetKeyMedia(key.Name);
                    foreach (var choice in key.Choices)
                    {
                        var description = doc.GetChoiceDescription(key.Name, choice.Value);
                        var media = doc.GetChoiceMedia(key.Name, choice.Value);
                        choice.Description = description;
                        choice.Media = media;
                    }
                }

                entity.RefreshFlagsDescriptions();
                entity.Issues = doc.Issues;
                entity.Notes = doc.Notes;
            }
        }

        private SpecsData GetDocumentation(Entity entity) 
        {
            var original = Specs.FirstOrDefault(a => a.Classname == entity.ClassName);
                
            var document = new SpecsData();
            
            // Get from original
            document.Classname = original.Classname;
            document.Description = original.Description;
            document.Issues = original.Issues;
            document.Notes = original.Notes;
            document.KeyDescriptions = new List<SpecsData.KeyDescription>();
            document.KeyDescriptions.AddRange(original.KeyDescriptions);

            var spawnFlags = entity.KeyValues.Where(a => a.Name == "spawnflags").ToList();
            foreach (var spawnFlag in spawnFlags) {
                foreach (var choice in spawnFlag.Choices) {
                    choice.Description = original.GetChoiceDescription ("spawnflags", choice.Value);
                }
            }
            
            CollectKeyDescriptionsFromBaseClasses(entity, document);
            return document;
        }

        private void CollectKeyDescriptionsFromBaseClasses(Entity entity, SpecsData document) 
        {
            if (entity.BaseClasses == null || entity.BaseClasses.Count <= 0)
                return;
            
            foreach (var baseClass in entity.BaseClasses)
            {
                // Add missing entries
                var specs = Specs.FirstOrDefault(a => a.Classname == baseClass);
                if (specs != null)
                {
                    document.KeyDescriptions.AddUnique(specs.KeyDescriptions);
                }

                // Recursive check for base classes of base classes
                var baseEntity = allEntities.FirstOrDefault(a => a.ClassName == baseClass);
                if (baseEntity != null) 
                {
                    var spawnFlags = baseEntity.KeyValues.Where(a => a.Name == "spawnflags").ToList();
                    foreach (var spawnFlag in spawnFlags) {
                        foreach (var choice in spawnFlag.Choices) {
                            if (string.IsNullOrEmpty(choice.Description))
                                choice.Description = specs.GetChoiceDescription ("spawnflags", choice.Value);
                        }
                    }
                    CollectKeyDescriptionsFromBaseClasses (baseEntity, document);
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