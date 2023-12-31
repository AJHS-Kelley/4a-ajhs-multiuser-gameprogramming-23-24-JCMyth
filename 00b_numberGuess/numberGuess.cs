using System.Runtime.Serialization.Json;
using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Net.Http.Headers;
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
           int cpuScore = 0;
           int playerGuess = 0;
           string difficulty = "";
           int rangeMin = -1;
           int rangeMax = -1;

           Console.WriteLine("Welcome to this game.\nHere is where you will select your difficulty.");
           Console.WriteLine("Easy: Range 0-10 with 4 guesses\nNormal: Range 0-25 with 3 guesses\n Hard: 0-50 with 2 guesses");

            // Difficulty selection
            Console.WriteLine("Please select Easy, Normal, or Hard and ress ENTER.");
            difficulty = Console.ReadLine();
            // Console.WriteLine() will save to STRING by default
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;

            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 3;

            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numGuesses = 2;
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);

            while (playerScore != 3 && cpuScore != 3) {
                // Any code you want to run Before each round goes here
                //GENERATE SECRET NUMBER
                Random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                Console.WriteLine(secretNumber);
                Console.WriteLine("Player Score: " + playerScore + "\n");
                Console.WriteLine("CPU Score: " + cpuScore + "\n");

                // START EACH ROUND
                for (int i = 0; i < numGuesses ; i++) {
                    //code to guess Number goes here
                    Console.WriteLine("You have used " + numAttempts + " this round.\n");
                    Console.WriteLine("You must guess between " + rangeMin + " and" + rangeMax + "\n");
                    playerGuess = System.Convert.ToInt32(Console.ReadLine());
                    if (playerGuess == secretNumber) {
                        Console.WriteLine("Great job! You got it right and earned a point.\n");
                        playerScore++;
                        break;
                    } else {
                        if (playerGuess > secretNumber) {
                            Console.WriteLine("Your guess is too high.\n");
                        } else {
                            Console.WriteLine("Your guess is too low.\n");
                        }
                    }
                    numAttempts++;
                }
                if (playerGuess != secretNumber) {
                    cpuScore++;
                    // Print a round lost message to the console.
                    Console.WriteLine("You lost and the CPU has gained a point");
                }
            }
            if (playerScore >= 3) {
                Console.WriteLine("You have won the game!\n");
            } else {
                Console.WriteLine("You have lost the game!\n");
            }

        }
    }



}