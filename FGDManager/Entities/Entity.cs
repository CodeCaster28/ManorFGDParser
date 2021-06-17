namespace FGDManager
{
    using System.Collections.Generic;
    using Properties; 

    public class Entity
    {
        public EntityType Type { get; set; }
        public string ClassName { get; set; }
        public string DocName { get; set; }

        public string[] BaseClasses { get; set; }
    }
}