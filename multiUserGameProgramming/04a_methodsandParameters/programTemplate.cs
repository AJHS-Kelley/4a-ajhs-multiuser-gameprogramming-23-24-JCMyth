// Julian Cunningham , Program Template, v0.02
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

        static int DoubleUp():
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }
        static void Main(string[] args)
        {
        //   MyMethod();
           DoubleUp();
        }
    }



}
