using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ArrayAndStringHelpers.StringHelpers;

namespace Test
{
    [TestClass]
    public class ReverseString
    {
        [TestMethod]
        public void TestReverseString()
        {
            CreateReverseStringTest(null, null);
            CreateReverseStringTest("", "");
            CreateReverseStringTest("a", "a");
            CreateReverseStringTest("ab", "ba");
            CreateReverseStringTest("cat", "tac");
            CreateReverseStringTest("happie", "eippah");
        }

        void CreateReverseStringTest(string test, string expected)
        {
            string actual = ReverseString(test);
            Assert.AreEqual(expected, actual);
        }
    }
}
