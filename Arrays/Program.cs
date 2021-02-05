// Author: Drake Ferry
// Date: 2/5/2021
// Class:ISM4300

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // The stopping point of the Array, meaning Array will stop at 25
            const int Array = 26;
            // ArrayIndex is the starting point of the Array 
            for (int ArrayIndex = 1; ArrayIndex < Array; ArrayIndex++)
            {
                // Displays Array for user 
                Console.WriteLine(ArrayIndex);
            }
        }
    }
}
