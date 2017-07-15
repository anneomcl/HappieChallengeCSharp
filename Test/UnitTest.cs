using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ArrayAndStringHelpers.StringHelpers;

namespace Test
{
    [TestClass]
    public class StringAndArrayTests
    {
        [TestMethod]
        public void TestStringCompression()
        {
            CreateStringCompressionTest(null, null);
            CreateStringCompressionTest(" ", " ");
            CreateStringCompressionTest("a", "a");
            CreateStringCompressionTest("aa", "aa");
            CreateStringCompressionTest("aaa", "a3");
            CreateStringCompressionTest("aaabbbccdd", "a3b3c2d2");
            CreateStringCompressionTest("aaaaa  bbbb   ", "a5 2b4 3");
        }

        public void CreateStringCompressionTest(string test, string expected)
        {
            string actual = CompressString(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFormatSpaces()
        {
            CreateFormatSpacesTest(null, null);
            CreateFormatSpacesTest("", "");
            CreateFormatSpacesTest(" ", "%20");
            CreateFormatSpacesTest("a", "a");
            CreateFormatSpacesTest(" a ", "%20a%20");
        }

        public void CreateFormatSpacesTest(string test, string expected)
        {
            string actual = FormatSpaces(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsPermutation()
        {
            CreateIsPermutationTest(null, null, true);
            CreateIsPermutationTest("", "", true);
            CreateIsPermutationTest("a", "a", true);
            CreateIsPermutationTest("a", "b", false);
            CreateIsPermutationTest("abc", "cab", true);
            CreateIsPermutationTest("doggierjr", "rdjogrgei", true);
            CreateIsPermutationTest("abc", "cab", true);
            CreateIsPermutationTest("abec", "cadb", false);
            CreateIsPermutationTest("eaaff", "cadb", false);
            CreateIsPermutationTest("dabc", "cadb", true);
        }

        void CreateIsPermutationTest(string test, string input, bool expected)
        {
            bool actual = isPermutation(test, input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestReverseString()
        {
            CreateReverseStringTest(null, null);
            CreateReverseStringTest("", "");
            CreateReverseStringTest("a", "a");
            CreateReverseStringTest("ab", "ba");
            CreateReverseStringTest("cat", "tac");
            CreateReverseStringTest("happie", "eippah");
            CreateReverseStringTest("happier", "reippah");
        }

        void CreateReverseStringTest(string test, string expected)
        {
            string actual = ReverseString(test, true);
            Assert.AreEqual(expected, actual);
            actual = ReverseString(test, false);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestUniqueCharactersInString()
        {
            CreateUniqueCharactersTest(null, true);
            CreateUniqueCharactersTest("", true);
            CreateUniqueCharactersTest("a", true);
            CreateUniqueCharactersTest("ab", true);
            CreateUniqueCharactersTest("aa", false);
            CreateUniqueCharactersTest("Aa", true);
            CreateUniqueCharactersTest("AA", false);
            CreateUniqueCharactersTest("aBcD&*j", true);
            CreateUniqueCharactersTest("aBcB&*j", false);
        }

        void CreateUniqueCharactersTest(string test, bool expected)
        {
            bool actual = hasAllUniqueCharacters(test);
            Assert.AreEqual(expected, actual);
        }
    }
}
