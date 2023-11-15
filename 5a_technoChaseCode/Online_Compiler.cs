/*
The purpose of this code is to test segments of my original code without risking damage to my actual code. as well as function as a note pad
Ideas for segments
    Add a segment that focuses on the damage of the critical attack
    Critical Attack has a chance to activate "ZONE" (True or false)
        Zone functions as increased chances for criticals 
        While in Zone attacks increase for up to 20 seconds(Might decrease later)
        Another Zone is possible but not as likely 
        
Purpose of the CritAttack segment
    User Attacks Enemy and has a chance to hit a critical
    Critical damage WILL BE determined in another segment
Current issues
    Attack can't be used as it "gives a different meaning to 'Attack', which is already used in a 'parent or current' scope to denote something else"
    Can't seem to get the return value to work
Solutions?
    Convert to string and assign values to be returned and called on later.
*/
using System;

namespace ExampleTests
{
    class ExampleTests
    {
        
        // Code to initialize whether a Critical attack is landed or not.
        static int CritAttack()
        {
            //Set up Critical attack chance
            int CritAttack; Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Press any key to attack.\n");
                string Attack;
                Console.ReadKey();
                CritAttack = random.Next(1, 6);
                // IF statement determines if the attack if critical, and assigns it a string name that can be used later.
                if (CritAttack == 3)
                {
                    Console.WriteLine("You've hit a jackpot! Bonus Damage achieved!\n");
                    Attack = "Critical";
                    // return 1; 
                    
                } 
                else    
                {
                    Console.WriteLine("Attack landed\ttest");
                    Attack = "Landed";
                    // return 2; 
                }
            
            }
            // return 0; 
        }   

        


        
        static void Main(string[] args)
        {
           CritAttack();
        }
        
        


    }
}
