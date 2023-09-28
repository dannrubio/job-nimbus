using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchingAngleBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings s = new Strings();
    
            string testString = "<><><><><ashdjhasjdhjakshdjkhaskjdhjkashjk::!!!dhjkashdjkasd><><><><div></div>";

            Console.WriteLine("String to test? ");
            testString = Console.ReadLine();

            string output = s.GetAngleBrackets(testString, "");
            //Console.WriteLine(output);
            //Console.WriteLine("Length={0}; IsPairable={1}", output.Length, s.IsPairable(output));
            Console.WriteLine("");
            Console.WriteLine("Has Matched Angle Brackets? {0}", s.AngleBracketsMatched(s.GetPairedStrings(output, s.IsPairable(output))));
        }
    }
}
