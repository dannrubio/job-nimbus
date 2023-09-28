using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatchingAngleBrackets;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Strings s = new Strings();
        [TestMethod]
        public void OpeningBracketStartsFollowedByClosedBracket()
        {
            string inputString = "<>";
            string cleanString = s.GetAngleBrackets(inputString, "");
            Assert.AreEqual(true, s.IsPairable(cleanString), "Test string should be pairable");

            bool result = s.AngleBracketsMatched(s.GetPairedStrings(cleanString, s.IsPairable(cleanString)));
            Assert.AreEqual(true, result, "Test string should have matched angle brackets");
        }

        [TestMethod]
        public void ClosedBracketStarts()
        {
            string inputString = "><";
            string cleanString = s.GetAngleBrackets(inputString, "");
            Assert.AreEqual(true, s.IsPairable(cleanString), "Test string should be pairable");

            bool result = s.AngleBracketsMatched(s.GetPairedStrings(cleanString, s.IsPairable(cleanString)));
            Assert.AreEqual(false, result, "Closed bracket can’t proceed all open brackets.");
        }

        [TestMethod]
        public void MultipleOpeningBracketStarts()
        {
            string inputString = "<<>";
            string cleanString = s.GetAngleBrackets(inputString, "");
            Assert.AreEqual(false, s.IsPairable(cleanString), "Test string should be pairable");

            bool result = s.AngleBracketsMatched(s.GetPairedStrings(cleanString, s.IsPairable(cleanString)));
            Assert.AreEqual(false, result, "Cannot have consecutive opening brackets.");
        }

        [TestMethod]
        public void MultipleClosingBracketStarts()
        {
            string inputString = ">><>";
            string cleanString = s.GetAngleBrackets(inputString, "");
            Assert.AreEqual(true, s.IsPairable(cleanString), "Test string should be pairable");

            bool result = s.AngleBracketsMatched(s.GetPairedStrings(cleanString, s.IsPairable(cleanString)));
            Assert.AreEqual(false, result, "Cannot have consecutive closing brackets.");
        }

        [TestMethod]
        public void EmptyString()
        {
            string inputString = "";
            string cleanString = s.GetAngleBrackets(inputString, "");
            Assert.AreEqual(true, s.IsPairable(cleanString), "Test string should be pairable");

            bool result = s.AngleBracketsMatched(s.GetPairedStrings(cleanString, s.IsPairable(cleanString)));
            Assert.AreEqual(true, result, "No brackets detected. Should be valid.");
        }

        [TestMethod]
        public void IgnoreContentBetweenBrackets()
        {
            string inputString = "<><><><><ashdjhasjdhjakshdjkhaskjdhjkashjk::!!!dhjkashdjkasd><><><><div></div>";
            string cleanString = s.GetAngleBrackets(inputString, "");
            Assert.AreEqual(true, s.IsPairable(cleanString), "Test string should be pairable");

            bool result = s.AngleBracketsMatched(s.GetPairedStrings(cleanString, s.IsPairable(cleanString)));
            Assert.AreEqual(true, result, "Test string should have matched angle brackets.");
        }
    }
}
