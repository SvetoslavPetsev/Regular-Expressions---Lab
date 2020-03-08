using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            Regex pattern = new Regex( @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            string text = Console.ReadLine();
            MatchCollection matches = pattern.Matches(text);

            foreach (var match in matches)
            {
                Console.Write(string.Join(" ", match) + " ");
            }
        }
    }
}
