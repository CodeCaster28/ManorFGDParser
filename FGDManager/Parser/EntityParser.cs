namespace FGDManager
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class EntityParser
    {
        public bool ParseEntity(string header, out Entity entity)
        {
            var pointer = 0;
            var entityType = GetType(header, ref pointer);
            var baseClasses = GetBaseClasses(header);
                
            pointer = header.IndexOf("=");

            var className = GetClassName(header, ref pointer);
            var docName = string.Empty;
            var messagePrint = $"@{entityType} = [{className}]";
            
            entity = new Entity()
            {
                Type = entityType,
                ClassName = className,
                DocName = docName,
            };
            
            if (baseClasses != null)
            {
                entity.BaseClasses = baseClasses;
                messagePrint = messagePrint + " (";

                for (var i = 0; i < baseClasses.Length; i++)
                {
                    messagePrint = messagePrint + $"{baseClasses[i]}";
                    
                    if (i < baseClasses.Length - 1)
                        messagePrint = messagePrint + "+";
                }
                
                messagePrint = messagePrint + ")";
            }
            
            if (TryGetDocName(header, ref pointer, out docName))
            {
                entity.DocName = docName;
                messagePrint = messagePrint + $" [{docName}]";
            }

            if (!header.EndsWith("[]"))
                GetEntitySettings();

            Console.WriteLine(messagePrint);
            return true;
        }

        private EntityType GetType(string header, ref int pointer)
        {
            var typeName = header.SubstringViableFromPointer(ref pointer);
            
            switch (typeName)
            {
                case var _ when typeName.Equals("@BaseClass"):
                    return EntityType.Base;
                case var _ when typeName.Equals("@PointClass"):
                    return EntityType.Point;
                case var _ when typeName.Equals("@SolidClass"):
                    return EntityType.Solid;
                default: return EntityType.Unknown;
            }
        }

        private string[] GetBaseClasses(string header)
        {
            var regex = new Regex(@"base\((.+?)\)");
            var match = regex.Match(header);
            if (match.Success)
            {
                var parameters = match.Groups[1].Value;
                parameters = parameters.Replace(" ", string.Empty);
                return parameters.Split(',');
            }

            return null;
        }
        
        private string GetClassName(string header, ref int pointer)
        {
            return header.SubstringViableFromPointer(ref pointer);
        }

        private bool TryGetDocName(string header, ref int pointer, out string docName)
        {
            docName = string.Empty;
            
            if (pointer >= header.Length - 1)
                return false;
            
            pointer++;
            
            docName = header.SubstringViableQuotedFromPointer(ref pointer);
            return docName != string.Empty;
        }

        private void GetEntitySettings()
        {
            
        }
    }
}