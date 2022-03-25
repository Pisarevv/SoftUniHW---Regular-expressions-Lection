using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\b(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z]{1}[a-z]{1,2})\2(?<year>\d{4})\b)";
            string inputDates = Console.ReadLine();

            MatchCollection validDates = Regex.Matches(inputDates, pattern);

            foreach (Match match in validDates)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
