using System.Linq;

namespace Notepad.Extensions
{
    public static class StringExtensions
    {
        public static string LeadingSpaces(this string text)
        {
            var spaces = "";

            foreach (var t in text)
            {
                if (t == ' ')
                    spaces += " ";
                else 
                    break;
            }

            return spaces;
        }

        public static bool OnlyContains(this string text, char c)
        {
            return text.All(t => t == c);
        }
    }
}