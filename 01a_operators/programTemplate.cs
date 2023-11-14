// Julian Cunningham , Program Templae, v0.03
using System;

namespace operator
{
    class program
    {
        static void Main(string[] args)
        {
           // Create TWO String, Integer, and Float variables
            int myInt1 = 18;
            int myInt2 = 938423;

            float myFloat1 = 0.989f; 
            float myFloat2 = 9.3f;

            string mystring1 = "I think you will like it here"; 
            string mystring2 = "Welcome to Trixonia";

            //Arithmetic Operators 
            Console.WriteLine(myint1 + myint2);
            Console.WriteLine(mystring1 + mystring2);
            Console.WriteLine(myFloat1 + myFloat2);
            Console.WriteLine(myint1 + myFloat2);    
            
            Console.WriteLine(myint1 - myint2);
//          Console.WriteLine(mystring1 - mystring2);
            Console.WriteLine(myFloat1 - myFloat2);
            Console.WriteLine(myint1 - myFloat2);

            Console.WriteLine(myint1 / myint2);
//           Console.WriteLine(mystring1 / mystring2);
            Console.WriteLine(myFloat1 / myFloat2);
            Console.WriteLine(myint1 / myFloat2);

            Console.WriteLine(myint1 * myint2);
//           Console.WriteLine(mystring1 * mystring2);
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myint1 * myFloat2);

            //modulus
            Console.WriteLine("Modulus")
            Console.WriteLine(10 % 2)
            Console.WriteLine(9 % 4)

            // Increment
            int  myInt3 = 1;
            myInt2++;
            Console.WriteLine(myInt3)

            //decrement
            int myInt4 = 2;
            myInt3--;
            Console.WriteLine(myInt4)

            // Assignment Operators
            // = THIS ASSIGNMENT OPERATORS THROWS OUT OLD VALUES
            myInt3 = 5;

            // These assignment operators keep old values!
            // +=
            myInt3 += -1;
            // -=
            myint3 -= 2;
            //*=
            myInt3 *= 3;
            // /=
            myInt3 /= 2;
            Console.WriteLine(myint3);

            // Comparison Operators
            // is equal to
            Console.WriteLine(5 == 4);
            // Not equal to
            Console.WriteLine(3 != 2);
            // Greater than
            Console.WriteLine(5 > 3);
            //Greater than or Equal to
            Console.WriteLine(55 >= 75);
            //Less Than
            Console.WriteLine(-1 < -2);
            //Less than or equal to
            Console.WriteLine(1 <= 5);

            //Logical Operators
            //And  -- ALL CONDITIONS MUST BE TRUE FOR THE WHOLE STATEMENT TRUE
            Console.WriteLine(3 >2 && 2 ==3); // TRUE AND TRUE = TRUE
            Console.WriteLine(3 >2 && 2 > 3);// FALSE AND TRUE = FALSE
            //Or -- One condition must be true for the whole statetement to be true
            Console.WriteLine(5 < 9 || 5 != 4);// True or true == true
            Console.WriteLine(9 < 10 || 3 > 5);// True or False == True
            //Not -- Find the 'opposite' value.
            Console.WriteLine(!(5 > 4));//
            Console.WriteLine();

        }
    }



}
