using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach(var number in numbers)
            {
                if(number % 2 ==0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach(var number in evens)
            {
                Console.WriteLine($"{number} is even");
            }

            Console.WriteLine();

            foreach(var number in odds)
            {
                Console.WriteLine($"{number} is odd");
            }
        }
    }
}
