namespace FGDManager
{
    using System;

    public class SpawnFlag : IComparable<SpawnFlag>
    {
        public Choice Source { get; set; }
        public string Value { get; set; }
        public string DocName { get; set; }
        public string Description { get; set; }
        
        public int CompareTo(SpawnFlag comparePart)
        {
            if (comparePart == null)
                return 1;

            var parsedFirst = Int64.Parse(Value);
            var parsedSecond = Int64.Parse(comparePart.Value);
            return parsedFirst.CompareTo(parsedSecond);
        }
    }
}