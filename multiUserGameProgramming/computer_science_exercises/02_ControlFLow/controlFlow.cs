// Julian Cunningham , Control Flow, v0.06
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
           // Declarations
            string favColor = "Purple";
            int luckyNumber = 8;
            float myGPA = 3.0577f;
            int myAge = 17;
            bool pineappleOnPizza = true;

            // if Statements -- Check for a single condition
            if (favColor == "Red") {
                Console.WriteLine("Red with rage.")
            }
            
            if (luckyNumber = 8){
                Console.WriteLine("I guess 7 ate 9. XD")
            }

            // if - else Statement -- Checks for a single condition, but has two values
            if (myAge > 15){
                Console.WriteLine("You are eligible to drive.")
            } else{
                Console.WriteLine("A bike is a healthier alternative.")
            }

            // if - else Statement -- Checks for multiple outcomes
            if (myGpa == 4.0f ){
                Console.WriteLine("Congrats on straight A grades!")
            } else if (myGpa >= 3.0f){
                Console.WriteLine("Congrats on making honor roll!")
            } else if (myGPA >= 2.0f){
                Console.WriteLine("You are graduation ready!")
            } else {
                Console.WriteLine("You should probably study.")
            }
            // WHEN CHECKING NUMBER VALUES, START WITH THE HIFHEST VALUE!!!!

            // Nested Statement
            if (pineappleOnPizza == true){
                Console.WriteLine("Eww, thats gross. You must be a boomer. How old are you?");
                if (myAge > 60) {
                    Conosole.WriteLine("Just as I suspected! what was it like having a dinosaur growing up?");
                } else {
                    Conosole.WriteLine("Ok, so you're not a boomer but still have no taste in food.");
                }
            else{
                Conosole.WriteLine("Glad to see you have common sense!");
            }
            // for Loop -- Best for when you know # of iterations needed.
            /*
                for (statement1; statement2; statement3) {
                    code to loop 
                }
                statement1 is executed ONCE BEFORE the loop starts.
                statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE a loop starts
                statement3 is executed EVERYTIME after the loop executes            
            */
            for(int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
            }
            //code to countdown from 100
            for(int i = 100; i > -1; i--) {
                Console.WriteLine("" + i);
            }
            // nested loops
            for (int i= 1; i <= 2; i++) {
                Console.WriteLine("Outer: " + i)
            
                for (int j = 1; j <= 2; j++) {
                Console.WriteLine("Inner: " + j)
                }
            }
            // while loop -- Best used when # of iterations needed is known
            int x = 0;
            while (x < 1000) {
                Console.WriteLine("" + x);
                x++;
            }
            int y = 1000;
            while (x < -1) {
                Console.WriteLine("" + y);
                 y--;
            }

            }

            // Special keyword
            // break will immediately exit a LOOP or an IF/ELSE IF/ELSE block
            for (int i = 0; i < 101; i++){
                Console.WriteLine("" + i)
                if (i == 50)
                break
            }
            // continue will SKIP the current iteration then finish the  loop
            for (int i = 0; i < 101; i++){
                Console.WriteLine("" + i)
                if (i == 50)
                continue
        }
    }



}
