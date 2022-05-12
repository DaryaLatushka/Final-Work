// See https://aka.ms/new-console-template for more information
using System;

namespace Final
{
    static class Program
    {

        public static void Main()

        {

            const int lengthOfShortString = 3;

            string[] sourceStrings = { "Sun", "Mond", "Tuesday",

            "Wednesday", "Thursday", "Fri", "af", "s" };

            int sourceStringsLength = sourceStrings.Length;

            String[] shortStrings = new String[sourceStringsLength];

            int shortStringsCount = 0;

            for (int i = 0; i < sourceStrings.Length; i++)
            {

                if (sourceStrings[i].Length <= lengthOfShortString)

                    shortStrings[shortStringsCount++] = sourceStrings[i];

            }

            Array.Resize(ref shortStrings, shortStringsCount);



            for (int i = 0; i < shortStrings.Length; i++)
            {

                Console.WriteLine("Short string:[{0}] = {1}", i, shortStrings[i]);

            }

        }

    }
}
