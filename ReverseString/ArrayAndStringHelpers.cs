﻿using System;
using System.Collections.Generic;

namespace ArrayAndStringHelpers
{
    public static class StringHelpers
    {
        static void ReverseCharArray(char[] testArray)
        {
            int length = testArray.Length;

            for (int i = 0; i < (length / 2); i++)
            {
                char temp = testArray[i];
                testArray[i] = testArray[length - i - 1];
                testArray[length - i - 1] = temp;
            }
        }

        public static string ReverseString(string test, bool useBuiltIn)
        {
            if (String.IsNullOrWhiteSpace(test) || test.Length < 2)
            {
                return test;
            }

            char[] testArray = test.ToCharArray();

            if (useBuiltIn)
            {
                Array.Reverse(testArray);
            }
            else
            {
                ReverseCharArray(testArray);
            }

            return new String(testArray);
        }

        public static bool hasAllUniqueCharacters(string test)
        {
            if (String.IsNullOrWhiteSpace(test) || test.Length < 2)
            {
                return true;
            }

            bool[] uniqueChecker = new bool[256];

            char[] testArray = test.ToCharArray();

            foreach (char letter in testArray)
            {
                if (uniqueChecker[letter])
                {
                    return false;
                }

                uniqueChecker[letter] = true;
            }

            return true;
        }

        public static bool isPermutation(string input, string test)
        {
            if (String.IsNullOrWhiteSpace(input) || input == test)
            {
                return true;
            }

            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            foreach (char letter in input)
            {
                if (letterCounts.ContainsKey(letter))
                {
                    letterCounts[letter]++;
                }
                else
                {
                    letterCounts.Add(letter, 1);
                }
            }

            Dictionary<char, int> testLetterCounts = new Dictionary<char, int>();
            foreach (char letter in test)
            {
                if (testLetterCounts.ContainsKey(letter))
                {
                    testLetterCounts[letter]++;
                }
                else
                {
                    testLetterCounts.Add(letter, 1);
                }
            }

            foreach (char item in letterCounts.Keys)
            {
                if (!testLetterCounts.ContainsKey(item)
                    || letterCounts[item] != testLetterCounts[item])
                {
                    return false;
                }
            }

            return true;
        }
    }
}