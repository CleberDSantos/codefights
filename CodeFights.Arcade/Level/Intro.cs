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

    }
}