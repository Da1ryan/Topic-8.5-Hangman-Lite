using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_8._5_Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrongGuesses = 0;
            string secretWord = "COMPUTER", displayWord = "________", guess;
            bool done = false;
            
            

            Console.WriteLine("WELCOME WILLING PARTICIPANT");
            Thread.Sleep(50);
            Console.WriteLine("TO");
            Thread.Sleep(50);
            Console.WriteLine("HANGMAN LITE!!!");
            Thread.Sleep(50);
            Console.WriteLine("");
            Thread.Sleep(50);
            Thread.Sleep(50);
            Console.WriteLine("The Rules are as followed");
            Thread.Sleep(50);
            Console.WriteLine("You will guess the letter of a SECRET WORD!");
            Thread.Sleep(50);
            Console.WriteLine("If you get the letter correct you will learn its position");
            Thread.Sleep(50);
            Console.WriteLine("BUT");
            Thread.Sleep(50);
            Console.WriteLine("IF YOU guess wrong, a man will slowly be hanged");
            Thread.Sleep(50);
            Console.WriteLine("BE CAREFULL as you only have 3 GUESSES");
            Thread.Sleep(50);
            Console.WriteLine("Until the innocent man is sadly hanged.");
            Thread.Sleep(50);
            Console.WriteLine("BUT NO TIME FOR THAT. LETS GET TO PLAYING");
            Thread.Sleep(50);
            while (!done)
            {
                
                Hangman(wrongGuesses);
                Console.WriteLine();
                Console.WriteLine(displayWord);
                Console.WriteLine();
                guess = "";
                while (guess.Length != 1)
                {
                    Console.WriteLine("Now what will your guess be?");
                    guess = Console.ReadLine().ToUpper().Trim();
                }
                
                if (wrongGuesses == 3)
                {
                    done = true;
                }
                bool correctGuess = false;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (guess[0] == secretWord[i])
                    {
                        displayWord = displayWord.Remove(i, 1);
                        displayWord = displayWord.Insert(i, guess);
                        correctGuess = true;
                        
                    }
                }
                if (!correctGuess)
                    wrongGuesses++;
                else if (!displayWord.Contains('_'))
                {
                    Hangman(wrongGuesses);
                    Console.WriteLine();
                    Console.WriteLine(displayWord);
                    Console.WriteLine("Congrats you Won");
                    Thread.Sleep(5000);
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    for (int i = 0; i<10; i++)
                    {
                        Console.WriteLine("Now get out!!!!!!!!!!");
                    }
                    Thread.Sleep(1600);
                    done = !done;
                }

            }
            



        }

        static void Hangman(int wrongGuesses)
        {
            switch (wrongGuesses)
            {
                case 0:

                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");

                    break;
                case 1:

                    Console.WriteLine("What is your next guess?");
                    Console.WriteLine("");
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");

                    break;
                case 2:

                    Console.WriteLine("And what about your last guess, what will it be?");
                    Console.WriteLine("");
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");

                    break;
                case 3:

                    Console.WriteLine("YOU LOSE!!!");
                    Console.WriteLine("");
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" / \\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    Thread.Sleep(500);
                    
                    break;
            }
            



        }
    }
}
