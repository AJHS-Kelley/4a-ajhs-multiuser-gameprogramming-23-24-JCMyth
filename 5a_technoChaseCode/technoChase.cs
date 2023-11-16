// Julian Cunningham , TechnoChase, v0.03
using System;

namespace ExampleTests
{
    class ExampleTests
    {
        // Code to determine whether player wishes to fight oponnent 
        static string Attackprompt()
        {
            string Landed;
            Console.WriteLine("Do you want to attack the enemy or run away?\n");
            Console.WriteLine("Please input Attack or Run away.\n");
            string PlayerResponse = Console.Readline();
                if (PlayerResponse == "Attack")
                    bool Landed = false;
                    Random rand = new Random();

                    if (rand.Next(0, 2) != 0)
                    {
                        Landed = true;
                        CritAttack();
                    } 
                    else
                    {
                        Console.WriteLine("You missed your attack... You can try again though.\n");
                    }
        }



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
          Attackprompt();  
                
        }
        
        


    }
}
