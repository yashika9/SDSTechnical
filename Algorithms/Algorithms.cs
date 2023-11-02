using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if(n == 0) return 0;

            int factorial = 1;

            while (n>0)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }

        public static string FormatSeparators(params string[] items)
        {
            var separatedString = "";
            for (int i = 0; i < items.Length; i++)
            {
                separatedString += items[i];
                if (i + 1 == items.Length - 1)
                {
                    separatedString += " and " + items[i + 1];
                    break;
                }
                else
                {
                    separatedString += ", ";
                }
            }
            return separatedString;
        }
    }
}