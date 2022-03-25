using System;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string regex = @"\b(?<firstName>[A-Z]{1}[a-z]{2,}) (?<secondName>[A-Z]{1}[a-z]{2,})\b";
        }
    }
}
