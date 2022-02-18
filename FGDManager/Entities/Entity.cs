namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Properties; 

    [System.Serializable]
    public class Entity
    {
        public EntityType Type { get; set; }
        public string ClassName { get; set; }
        public string DocName { get; set; }
        public List<string> BaseClasses { get; set; } = new List<string>();
        public string Description { get; set; }
        public List<KeyValue> KeyValues { get; } = new List<KeyValue>();
        public List<KeyValue> InheritedKeyValues { get; } = new List<KeyValue>();
        public List<KeyValue> FinalKeyValues { private set; get; } = new List<KeyValue>();
        public Dictionary<string, string> KeysDescriptionsOverride { get; } = new Dictionary<string, string>();
        public List<SpawnFlag> SpawnFlags { get; private set; } = new List<SpawnFlag>();
        public List<string> Notes { get; set; } = new List<string>();
        public List<string> Issues { get; set; } = new List<string>();
        
        public void CreateFinalKeyValues() 
        {
            FinalKeyValues = new List<KeyValue>(InheritedKeyValues);
            FinalKeyValues.AddRange(KeyValues);
            FinalKeyValues = RemoveDuplicatedKeyvalues(FinalKeyValues);
            FinalKeyValues = FinalKeyValues.DeepClone();
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

        private List<KeyValue> RemoveDuplicatedKeyvalues(List<KeyValue> keyvalues)
        {
            var outputList = new List<KeyValue>();
            for (var i = 0; i < keyvalues.Count; i++)
            {
                var alreadyAdded = outputList.Any(a => a.Name == keyvalues[i].Name);
                if (!alreadyAdded || keyvalues[i].Name == "spawnflags")
                {
                    outputList.Add(keyvalues[i]);
                }
                else
                {
                    // Replace
                    var index = outputList.IndexOf(outputList.First(a => a.Name == keyvalues[i].Name));
                    outputList[index] = keyvalues[i];
                    //Console.WriteLine(ClassName + " keyvalue already present: " + keyvalues[i].Name);
                }
            }

            //outputList.Reverse();
            return outputList;
        }

        public string GetDescriptionForKey(KeyValue key)
        {
            return KeysDescriptionsOverride.ContainsKey(key.Name) ? KeysDescriptionsOverride[key.Name] : key.Description;
        }
    }
}