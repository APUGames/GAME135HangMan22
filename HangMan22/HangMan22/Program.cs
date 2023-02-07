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
            string playerInput;
            playerInput = Console.ReadLine();

            char? playerChoice;
            if (playerInput == null && playerInput != "")
            {
                playerChoice = playerInput?[0];
            }
            else
            {
                playerChoice = '*';
            }
            

            Console.WriteLine(playerChoice);
        }
    }
}
