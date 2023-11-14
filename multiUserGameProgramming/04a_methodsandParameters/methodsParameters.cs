// Julian Cunningham , Program Template, v0.04
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD -- named block of code, can be used over and over.
        // All methods have a SIGNATURE that defines their name, parameters, and output.
        // Example Signature
        /*static void MyMethod()
        {
            Console.WriteLine("The game costed about $80 with add-ons.");
        }*/
        // static -- This method belongs to the current class, it is Not an object
        //void -- This method has no return value.

       /* static int DoubleUp():
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }
*/
        //Methods with Parameters
        /* static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("One pancake coming up!\n");
            }
        }
        */
       /* static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have oredered " + num + " eggs cooked in " + style);
        }
        
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + " hamburgers.\n");
        }
        */
        // Named Arguments
        /* static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My favorite child is " + child3);
        }*/
        
        //METHOD OVERLOADING
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        static double FindSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        static void Main(string[] args)
        {
        //   MyMethod();
        //   DoubleUp();
        //   MakePancakes(3);
        //   MakeEggs(10, "sunny side up");
        //  MakeBurger();
        //  MakeBurger(10);
        //  AllMyChildren(child3: "bob", child2: "trish", child1: "thomas");
        FindSum(8, 3);
        FindSum(8.7, 2.1);
        FindSum(4, 2.7);
        }
    }
}
