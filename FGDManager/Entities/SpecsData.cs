namespace FGDManager
{
    using System.Collections.Generic;
    using System.Linq;

    public class SpecsData
    {
        public class ChoiceDescription
        {
            public string choiceValue { get; set; }
            public string choiceDescription { get; set; }
        }
        
        public class KeyDescription
        {
            public string keyName { get; set; }
            public string keyDescription { get; set; }
            public List<ChoiceDescription> keyChoices { get; set; }
        }
        
        public string Classname  { get; set; }
        
        public string Description { get; set; }

        public List<KeyDescription> KeyDescriptions { get; set; } = new List<KeyDescription>();
        
        public void AddKey(string name, string description, List<ChoiceDescription> choices = null)
        {
            var key = new KeyDescription()
            {
                keyName = name,
                keyDescription = description,
                keyChoices = choices
            };
            KeyDescriptions.Add(key);
        }

        public string GetKeyDescription(string keyName)
        {
            var key = KeyDescriptions.FirstOrDefault(a => a.keyName == keyName);
            return key?.keyDescription;
        }
        
        public string GetChoiceDescription(string keyName, string choiceValue)
        {
            var key = KeyDescriptions.FirstOrDefault(a => a.keyName == keyName);
            var choice = key?.keyChoices.FirstOrDefault(a => a.choiceValue == choiceValue);
            return choice?.choiceDescription;
        }
    }
}