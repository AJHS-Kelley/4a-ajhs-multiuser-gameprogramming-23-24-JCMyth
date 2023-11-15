using System;

namespace ExampleTests
{
    class ExampleTests
    {
        static void methodone()
        {

        }

        static void methodtwo()
        {

        }

        static int CritAttack(boost)
        {
            //Set up Critical attack chance
            int CritAttack; Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Press any key to attack./n");
                 
                Console.ReadKey();
                CritAttack = random.Next(1, 6);
                if (CritAttack == 3)
                {
                    Console.WriteLine("You've hit a jackpot! Bonus Damage achieved!/n");
                    string Attack = "Critical";
                    
                } 
                else    
                {
                    Console.WriteLine("Attack landed/n");
                    string Attack = "Landed";
                    
                }
            return Attack();
            }   
        }   

        


        
        static void Main(string[] args)
        {
           CritAttack();
        }
        



    }
}
