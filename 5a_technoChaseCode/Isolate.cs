using System;
using System.Collections;



namespace ExampleTests
{
    class ExampleTests
    {
        static void Main(string[] args)
        {
            WeaponChoice();
        }
        
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
                else if (i == Weapons.Count-1)
                {
                    Console.WriteLine("This not a weapon, buttt I'll add it to the list");
                    Weapons.Add(WeaponChoice);
                }
            }
            Console.WriteLine("\n" + WeaponChoice + "... Is this your choice of weapon?\n");
            string confirmation = Convert.ToString(Console.ReadLine());
            if (confirmation == "yes")
            {
                Weapons.Add(WeaponChoice);
                Console.WriteLine("This is your current list of weapons:\n" );
                foreach (var item in Weapons)
                {
                    Console.WriteLine(item);
                }
            }else 
            {
                Console.WriteLine("Please choose a weapon of your choice");
            }
        }
    }
} 
// Code reviewed  by Ronald Durham