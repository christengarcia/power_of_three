/*
 *  C# Program to Calculate Power of Three
 */

using System;

namespace power_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            new GeneratePowers().RaiseToPower
               (5,    // 4 values per table
                3);
            Console.ReadLine(); // power to raise each value
        }
    }
}
