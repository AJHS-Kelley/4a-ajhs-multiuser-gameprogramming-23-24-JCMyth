// Julian Cunningham , TechnoChase, v0.02
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM
    {
        static void methodone()
        {

        }

        static void methodtwo()
        {

        }

        static int CritAttack()
        {
            //Set up Critical attack chance
            int CritAttack; Random random = new Random();
            for (int i = 0; i < 2; i++){
                Console.WriteLine("Press any key to attack./n");
                Console.ReadKey();
                CritAttack = random.Next(1, 6);
                if (CritAttack == 3){
                    Console.WriteLine("You've hit a jackpot! Bonus Damage achieved!");
                    CritAttack = 1
                    return CritAttack
                } else {
                    Console.WriteLine("Attack landed");
                    CritAttack = 0
                    return CritAttack
                }
        }
    }

        static returntype methodFour()
        {

        }


        {
        static void Main(string[] args)
        {
           CritAttack();
        }
    }



    }
}
