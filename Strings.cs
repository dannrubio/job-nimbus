using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchingAngleBrackets
{
    public class Strings
    {
        const string regexp1 = @"[^a-zA-Z\d\s:<>]";
        const string regexp2 = @"[a-zA-Z\d\s:]";

        public string GetAngleBrackets(string srcString, string chrReplace = "")
        {
            Regex regExp1 = new Regex(regexp1);
            Regex regExp2 = new Regex(regexp2);
            return regExp2.Replace(regExp1.Replace(srcString, chrReplace), chrReplace);
        }

        public bool IsPairable(string srcString)
        {
            return (srcString.Length % 2) == 0;
        }

        public List<string> GetPairedStrings(string srcString, bool isPairable)
        {
            var result = new List<string>();

            if (isPairable) {
                for (int i = 0; i < srcString.Length; i++)
                {
                    result.Add(srcString.Substring(i, 2));
                    i++;
                }
            } else result.Add(srcString);

            return result;
        }

        public bool AngleBracketsMatched(List<string> l)
        {
            return l.All(i => i.Equals("<>"));
        }
    }
}
