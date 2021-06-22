namespace FGDManager
{
    using System.Collections.Generic;

    public class KeyValue
    {
        public Entity ParentEntity { get; private set; }
        public List<Choice> Choices { get; } = new List<Choice>();
        public string Name { get; set; }
        public string Type { get; set; }
        public string DocName { get; set; }
        public string Description { get; set; }

        public KeyValue(Entity parentEntity)
        {
            ParentEntity = parentEntity;
        }
    }
}