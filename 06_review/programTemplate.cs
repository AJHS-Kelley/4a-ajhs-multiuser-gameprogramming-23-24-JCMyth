// Julian Cunningham , Program Templae, v0.01
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
            //cDeclaring and Assigning Variables
            // Integer = 4 Bytes
           int hits = 1;

           // Long -- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
           // Long -- 8 Bytes
           long myLong = 1928742747242894;

           //Float -- Stores up to 6-7 decimal digits
           // Float = 4 Bytes 
           float height = 2.4f;

           // Double -- Stores up to 155 decimal digits
           // Double = 8 Bytes
           double ourDouble = 9.123456789102345D;

           // Boolean -- true / false
           // Boolean = 1 bit
           bool landed = true;

           // String
           // 2-Bytes per character
           // Must be in DOUBLE QUOTES " "
           string noString = "Boo!";

           // Character (char)
           // Signle character, in SINGLE QUOTES ' ' 
           // 2-Bytes
           char myChar = 'C';

           // Type Casting -- changing one data type to another
           // IMPLICIT -- happens automatically when going smaller -> larger
           // char -> int -> long -> float -> double
           int myint = 9;
           double myDouble = myint;
           Console.WriteLine(myDouble);


           // EXPLICIT -- Must be done manually when going larger -> smaller
           // double -> float -> long -> int -> char
           double exampleDouble = 9.756212345D;
           int myInt = (int) myDouble;

           // Conversion Methods
           string myString = Convert.ToString(myint); // String
           float newHeight = Convert.ToFloat(height); // Float
           Convert.ToInt32(); // Integer
           Convert.ToInt64(); // Long

           // Switch Statement
           int dayOfWeek = 5;
           switch (dayOfWeek)
           {
                case 1:
                    Console.WriteLine("The day is Sunday.\n");
                    break;
                case 2:
                    Console.WriteLine("The day is Monday.\n");
                    break;
                case 3:
                    Console.WriteLine("The day is Tuesday.\n");
                    break;
                case 4:
                    Console.WriteLine("The day is Wednesday.\n");
                    break;
                case 5:
                    Console.WriteLine("The day is Thursday.\n");
                    break;
                case 5:
                    Console.WriteLine("The day is Friday.\n");
                    break;
                case 7:
                    Console.WriteLine("The day is Saturday.\n");
                    break;
                default:
                    Console.WriteLine("No match found.\n")
                    break;

           }

           
        }
    }



}


