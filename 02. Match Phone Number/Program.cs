using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            Regex pattern = new Regex (@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");

            string text = Console.ReadLine();

            MatchCollection telNumbers = pattern.Matches(text);

            Console.WriteLine(string.Join(", ", telNumbers));
        }
    }
}
