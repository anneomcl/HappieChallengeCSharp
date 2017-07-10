using System;

namespace ArrayAndStringHelpers
{
    public static class StringHelpers
    {
        public static string ReverseString(string test)
        {
            if (String.IsNullOrWhiteSpace(test) || test.Length < 2)
            {
                return test;
            }

            char[] testArray = test.ToCharArray();
            for (int i = 0; i < (test.Length / 2); i++)
            {
                char temp = testArray[i];
                testArray[i] = testArray[test.Length - i - 1];
                testArray[test.Length - i - 1] = temp;
            }

            return new String(testArray);
        }
    }
}