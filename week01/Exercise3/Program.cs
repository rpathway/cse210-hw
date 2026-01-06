using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        do
        {
            Random randomNumberGenerator = new Random();
            int magicNumber = randomNumberGenerator.Next(1, 101);
            int guessInt;
            int numGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessInt = int.Parse(guess);

                numGuesses++;
                
                if (guessInt > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

            } while (guessInt != magicNumber);

            Console.WriteLine("\nYou guessed it!");
            Console.WriteLine($"It took you {numGuesses} tries!");

            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}