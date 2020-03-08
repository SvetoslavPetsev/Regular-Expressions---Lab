using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main()
        {
            Regex pattern = new Regex (@"\b(?<day>\d{2})([-.\/])(?<month>[A-z][a-z]{2})\1(?<year>\d{4})\b");
            string text = Console.ReadLine();

            MatchCollection dates = pattern.Matches(text);

            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
