using System;

namespace GuessingNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if ( i > winNum)
                {
                    Console.WriteLine("Too high, guess lower!");
                }
                else if ( i < winNum)
                {
                    Console.WriteLine("Too low, guess higher!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You WIN!");
                    win = true;
                }
            } while (win == false);

            Console.WriteLine();
            Console.WriteLine($"The winning number is {winNum}!");
            Console.WriteLine("Press any key to exit!");
        }
    }
}
