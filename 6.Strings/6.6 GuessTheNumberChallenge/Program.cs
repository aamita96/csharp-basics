// See https://aka.ms/new-console-template for more information
using System;

namespace Challenge {
    class GuessTheNumber {
        static void Main(string[] args){
            // Choose a random number between 0 and 20;
            int theNumber = new Random().Next(20);
            int userGuess = 0;
            int guesses = 1;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");

            bool succeeded;
            while (userGuess != -1)
            {
                Console.WriteLine("Enter your guess, or -1 to give up.");
                succeeded =  Int32.TryParse(Console.ReadLine(),out userGuess);
                if(!succeeded){
                    Console.WriteLine("Whoops! The entered string does not seem's a number.");
                    guesses++;
                    continue;
                }
                if(userGuess == theNumber){
                    Console.WriteLine("You've guessed it right. Congratulations 🎊");
                    Console.WriteLine($"You took {guesses} guesses.");
                    break;
                }
                
                Console.WriteLine("Nope, number is {0} than that.",userGuess > theNumber ? "lower": "higher");
                guesses++;
            }
        }
    }
}
