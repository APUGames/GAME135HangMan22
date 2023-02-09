/**
 * Author: Jesus Noland
 * Creation date: 02-06-2023
 * Purpose: Hangman game
 */
using System;

namespace HangMan
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] wordBank =
            {
                "james",
                "mark",
                "luke",
                "john",
                "acts",
                "romans"
            };

            bool playerWon = false;

            // Select a word randomly from the word bank
            Random random = new Random();
            int randomWordIndex = random.Next(0, wordBank.Length);
            string chosenWord = wordBank[randomWordIndex];

            // Build an empty character array of the same length
            // as the chosen word to check the player's input against

            while (true)
            {
                // The null-conditional operator allows our
                // string variable to accept a possible null
                // value from ReadLine
                string? playerInput;
                playerInput = Console.ReadLine();

                char? playerChoice;
                if (playerInput != null && playerInput != "")
                {
                    if (playerInput == "quit")
                    {
                        // If the player types quit then
                        // leave the game loop.
                        break;
                    }

                    playerChoice = playerInput?[0];

                    Console.WriteLine("You have chosen " + playerChoice);
                }
            }

            if (playerWon)
            {
                Console.WriteLine("You won the game!");
            }
        }
    }
}
