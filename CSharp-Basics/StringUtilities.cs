using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class StringUtilities
    {
        public static string Summarize(string text, int maxLength = 20)
        {
            if (text.Length <= maxLength)
                return text;
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
                summaryWords.Add(word);
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
