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
using System.Collections;
namespace ExampleTests
{
    class ExampleTests
    {
        //Code to select element or weapons
         static void WeaponChoice()
        {
            var Weapons = new ArrayList()
            {
                "Sword", "Axe", "dagger", "Gun", "Potato launcher"
            };
                
                
            Console.WriteLine("Please select a weapons of your choice.\n");
            string WeaponChoice = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < Weapons.Count-1; i++)
            {
                if (WeaponChoice == Weapons[i].ToString())
                {
                    break;
                }
            }
            Console.WriteLine("\n" + WeaponChoice + "... Is this your choice of weapon?\n");
            string confirmation = Convert.ToString(Console.ReadLine());
            if (confirmation == "yes" || confirmation == "Yes")
            {
                Console.WriteLine("This may not be a weapon, buttt I'll add it to the list anyway.");
                Weapons.Add(WeaponChoice);
                Console.WriteLine("This is your current list of weapons:\n" );
                foreach (var item in Weapons)
                {
                    Console.WriteLine(item);
                }
            }else if (confirmation == "No" || confirmation == "no")
            {
                Console.WriteLine("Please choose a weapon of your choice (The weapon you choose WILL be FINAL this time).\n");
                string NewWeapon = Convert.ToString(Console.ReadLine());
                Weapons.Add(NewWeapon);
                Console.WriteLine("This may not be a weapon, but I'll add it to the list anyway.");
                Console.WriteLine("This is your current list of weapons:\n" );
                foreach (var item in Weapons)
                {
                    Console.WriteLine(item);
                }

                
            }
            else
            {
                Console.WriteLine("Please input Yes or No.");
                string DoubleCheck = Convert.ToString(Console.ReadLine());
                if (DoubleCheck == "yes" || DoubleCheck == "Yes")
            {
                Console.WriteLine("This may a weapon, buttt I'll add it to the list anyway.");
                Weapons.Add(WeaponChoice);
                Console.WriteLine("This is your current list of weapons:\n" );
                foreach (var item in Weapons)
                {
                    Console.WriteLine(item);
                }
            }else if (DoubleCheck == "No" || DoubleCheck == "no")
            {
            Console.WriteLine("Please choose a weapon of your choice (The weapon you choose WILL be FINAL this time).\n");
            }
            }
        }

        // Code to determine whether player wishes to fight oponnent 
        static string Attackprompt()
        {
            
            Console.WriteLine("Do you want to attack the enemy or run away?\n");
            Console.WriteLine("Please input Attack or Run away.\n");
            string PlayerResponse = Console.ReadLine();
            // Code will check for player response and ract based on the result
            while (PlayerResponse != "Attack" || PlayerResponse != "Run")
            {
                   
                if (PlayerResponse == "Attack")
                    {
                    Console.WriteLine("Hello\n") ;
                    CritAttack();
                    return "Fight";
                    }
                    
                else if (PlayerResponse == "Run")
                    {
                    Console.WriteLine("There's always next time\n");
                    return "Run";
                    }
                else    
                    {
                    Console.WriteLine("Please input your answer\n");
                    return "No Response";
                    Console.WriteLine("Please input Attack or Run away.\n");

                    }
            }   
            return "finished";
        }



        // Code to initialize whether a Critical attack is landed or not.
        static int CritAttack()
        {
            //Set up Critical attack chance
            int CritAttack; Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Press SPACE to attack.\n");
                string Attack;
                Console.ReadKey();
                CritAttack = random.Next(1, 6);
                // IF statement determines if the attack if critical, and assigns it a string name that can be used later.
                if (CritAttack == 3)
                {
                    Console.WriteLine("You've hit a jackpot! Bonus Damage achieved!\n");
                    Attack = "Critical";
                    
                     return 1; 
                    
                } 
                else    
                {
                    Console.WriteLine("Attack landed\t");
                    Attack = "Landed";
                     return 2; 
                }
            
            }
             return 0; 
        }   

        // Code to iniate the zone
        
            


        
        static void Main(string[] args)
        {
        WeaponChoice();
        Attackprompt();  
                
        }
        
        


    }
}