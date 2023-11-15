// Julian Cunningham , Program Templae, v0.01
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM
    {
        // Add my methods here
        static int CritAttack()
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
                    Console.WriteLine("You've hit a jackpot! Bonus Damage achieved!");
                    CritAttack = 1
                    return CritAttack();
                }
                 else 
                {
                    Console.WriteLine("Attack landed");
                    CritAttack = 0
                    return CritAttack();
                }
            }
    }
        
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
           CritAttack();
        }
    }



}
