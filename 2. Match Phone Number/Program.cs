using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |\-)2\1\d{3}\1\d{4}\b";
            string phoneNumbers = Console.ReadLine();

            MatchCollection validPhoneNumbers = Regex.Matches(phoneNumbers, pattern);
            

            Console.Write(string.Join(", ", validPhoneNumbers));
        }
    }
}
