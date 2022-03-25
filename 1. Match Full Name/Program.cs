using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b(?<firstName>[A-Z]{1}[a-z]{1,}) (?<secondName>[A-Z]{1}[a-z]{1,})\b";

            

            MatchCollection matches = Regex.Matches(names,pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
