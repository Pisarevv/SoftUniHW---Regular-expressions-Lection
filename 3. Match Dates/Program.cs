using System;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z]{1}[a-z]{1,2})\2(?<year>\d{4})";
        }
    }
}
