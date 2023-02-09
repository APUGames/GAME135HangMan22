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
            bool playerWon = false;

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
