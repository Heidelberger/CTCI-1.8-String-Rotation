using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_1._8_String_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeaderMsg(1, 8, "String Rotation");

            string string0 = "waterbottle";
            string string1 = "erbottlewat";
            string string2 = "water bottle";

            if (isRotation_DotNet(ref string0, ref string1))
                Console.WriteLine(string1 + " is a rotation of " + string0);
            else
                Console.WriteLine(string1 + " is not a rotation of " + string0);

            Console.WriteLine();

            if (isRotation_DotNet(ref string0, ref string2))
                Console.WriteLine(string2 + " is a rotation of " + string0);
            else
                Console.WriteLine(string2 + " is not a rotation of " + string0);

            Console.ReadLine();
        }


        //////////////////////////////////////////////////////////////
        //        
        // Check if strings are null or empty. Check if same length.
        //
        // Double one of the strings and see if it contains the other (fixes 
        // "word wrap" (AKA rotation) problem.
        // 
        // Complexity: Algorithm runs in O(N) time
        //             Every element must be touched once to check for a match.
        //             I'm assuming String.Contains() uses the Boyer-Moore algorithm.
        //             https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore_string_search_algorithm
        //
        //             Algorithm requires O(N) space
        //             The method concatenates one of the strings to itself, requiring
        //             2 characters of memory for every 1 character in that string.        
        //
        private static bool isRotation_DotNet(ref string string0, ref string string1)
        {
            if (String.IsNullOrEmpty(string0) || String.IsNullOrEmpty(string1))
                return false;

            if (string0.Length != string1.Length)
                return false;

            return (string1 + string1).Contains(string0);
        }

        private static void PrintHeaderMsg(int chapter, int problem, string title)
        {
            Console.WriteLine("Cracking the Coding Interview");
            Console.WriteLine("Chapter " + chapter + ", Problem " + chapter + "." + problem + ": " + title);
            Console.WriteLine();
        }
    }
}
