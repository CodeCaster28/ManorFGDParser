namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Properties; 

    public class Entity
    {
        public EntityType Type { get; set; }
        public string ClassName { get; set; }
        public string DocName { get; set; }
        public List<string> BaseClasses { get; set; } = new List<string>();
        public string Description { get; set; }
        public List<KeyValue> KeyValues { get; } = new List<KeyValue>();
        public List<KeyValue> InheritedKeyValues { get; } = new List<KeyValue>();
        public List<SpawnFlag> SpawnFlags { get; private set; } = new List<SpawnFlag>();
        public List<string> Notes { get; set; } = new List<string>();
        public List<string> Issues { get; set; } = new List<string>();
        
        public List<KeyValue> GetAllKeyValues()
        {
            var allKeyValues = new List<KeyValue>(InheritedKeyValues);
            allKeyValues.AddRange(KeyValues);

            return allKeyValues;
        }

        public void RegisterSpawnFlag(Choice source)
        {
            var flag = SpawnFlags.FirstOrDefault(x => x.Value == source.Value);
            if (flag == null)
            {
                var newSpawnFlag = new SpawnFlag()
                {
                    Value = source.Value,
                    DocName = source.DocName,
                    Source = source
                };
                SpawnFlags.Add(newSpawnFlag);
            }
            else
            {
                flag.DocName = source.DocName;
                flag.Source = source;
            }
        }

        public void RefreshFlagsDescriptions()
        {
            foreach (var flag in SpawnFlags)
            {
                flag.Description = flag.Source.Description;
            }

            SpawnFlags.Sort();
        }
    }
}