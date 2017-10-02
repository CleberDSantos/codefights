using System;

namespace CodeFights.Arcade
{
    internal static class Intro
    {

        public static int centuryFromYear(int year) {

            var div = (year / 100);

            if (year % 100 > 0)
            {
                div++;
            }

            return div;

        }

        public static bool checkPalindrome(string inputString)
        {

            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);

            var reverseWord = new string(arr);

            if (inputString == reverseWord)
            {
                return true;
            }

            return false;
        }

        public static int adjacentElementsProduct(int[] inputArray)
        {

            int hightValue = 0;

            for (int i = 0; i < inputArray.Length -1; i++)
            {
                var element = inputArray[i];
                var nextElement = inputArray[i + 1];

                var val = element * nextElement;

                if (hightValue == 0)
                {
                    hightValue = val;
                }

                if (val > hightValue)
                {
                    hightValue = val;
                }

            }

            return hightValue;
        }

    }
}