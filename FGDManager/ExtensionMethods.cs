namespace FGDManager
{
    using System.Collections.Generic;
    using System.Text;
    using static System.Console;
    
    public static class StringExtensions
    {
        public static string SubstringByIndexes(this string value, int startIndex, int endIndex)
        { 
            return value.Substring(startIndex, (endIndex - startIndex + 1));
        }

        public static string SubstringBetween(this string value, string first, string second)
        {
            int strFrom = value.IndexOf(first) + first.Length;
            int strTo = value.LastIndexOf(second);

            return value.Substring(strFrom, strTo - strFrom);
        }

        public static string SubstringViableFromPointer(this string value, ref int pointer)
        {
            bool IsPartOfName(char c)
            {
                return char.IsLetter(c) || char.IsNumber(c) || c == '_' || c == '@';
            }
            
            StringBuilder className = new StringBuilder();
            var waitForCharactersStart = true;
            var startIndex = -1;
            var endIndex = value.Length - 1;
            
            for (var i = pointer; i < value.Length - 1; i++)
            {
                if (waitForCharactersStart)
                {
                    if (IsPartOfName(value[i]))
                    {
                        startIndex = i;
                        waitForCharactersStart = false;
                    }
                }
                else
                {
                    if (!IsPartOfName(value[i]))
                    {
                        endIndex = i - 1;
                        pointer = i;
                        break;
                    }
                }
            }

            return startIndex == -1 ? string.Empty : value.SubstringByIndexes(startIndex, endIndex);
        }
        
        public static string SubstringViableQuotedFromPointer(this string value, ref int pointer)
        {
            StringBuilder className = new StringBuilder();
            var waitForCharactersStart = true;
            var startIndex = -1;
            var endIndex = value.Length - 1;
            
            for (var i = pointer; i < value.Length - 1; i++)
            {
                if (waitForCharactersStart)
                {
                    if (value[i] == '\"')
                    {
                        startIndex = i + 1;
                        waitForCharactersStart = false;
                    }
                }
                else
                {
                    if (value[i] == '\"')
                    {
                        endIndex = i;
                        pointer = i;
                        break;
                    }
                }
            }

            return startIndex == -1 ? string.Empty : value.SubstringByIndexes(startIndex, endIndex - 1);
        }
    }
}