using System.Runtime.Serialization;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using Internal;
// Julian Cunningham , numberGuess, v0.02
/*
Generate secret number from a defined range of numbers (i.e 0-10, 0-50, 0-100)
Print game instructions including range and num of guess allowed
    MATCH == first player to score 3 points
    ROUND == guess a specific number, until correct or no more attempts left
Ask the player what difficulty they want to play on
Ask the player what their guess is
Determine if guess is correct or not
    If guess is correct{
        Tell them they have guessed correctly.
        Awar the player a point.
    } else {
        Tell them they are wrong.
        Tell player if guess is too high or too low
        Check to see if they have guesses remaining {
            if guess remain : {
                allow player to gues again.
            } else {
                CPU wins the round.
            }
        }

    }

*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
           int secretNumber = -1; 
           int numGuesses = 0; // Number of guesses the player is ALLOWED.
           int numAttempts = 0; // Number of guesses TAKEN
           int playerScore = 0;
           int cpuScore = 0
           string difficulty = "";
           int rangeMin = -1;
           int rangeMax = -1;

           Console.WriteLine("Welcome to this game.\nHere is where you will select your difficulty.")
           Console.WriteLine("Easy: Range 0-10 with 4 guesses\nNormal: Range 0-25 with 3 guesses\n Hard: 0-50 with 2 guesses")

            // Difficulty selection
            Console.WriteLine("Please select Easy, Normal, or Hard and ress ENTER.")
            difficulty == Console.ReadLine();
            // Console.WriteLine() will save to STRING by default
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;

            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numGuess = 3;

            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numGuess = 2;
            }
            Console.Writeline("Minimum: " + rangeMin);
            Console.Writeline("Maximum: " + rangeMin);

            while (playerScore != 3 && cpuScore != 3) {
                // Any code you want to run Before each round goes here


                // START EACH ROUND
                for (int i = 0; i < numGuess ; i++) {
                    numGuess 
                    break
                }
            }

        }
    }



}