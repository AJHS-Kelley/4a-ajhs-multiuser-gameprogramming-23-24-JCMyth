using System.Reflection.Emit;
using System.Data;
using System.Text;
using Internal;
// 02_Collections, Julian Cunningham, 10/3/23 v0.1a

using System;

namespace _02_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable

            /* Arrays
            -- Number of eleements in an array CANNOT change.
            -- Contents of elements in an array CAN change.
            -- Items in the array are called ELEMENTS.
            --Arrays are ordered, meaning each item has fixed position
            -- the position is known as the INDEX.
            First element in an array is index 0.
            */

            // Declaring and Defining an Array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "cereal", "Parfait"};
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 099f, 4.25f};

            // Print Array Contents -- All Elements on a Single Line
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + string.Join(", ", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + string.Join(", ", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + string.Join(", ", GPA));
            Console.WriteLine();

        }
    }
}