using System;

namespace numberguess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            bool playing = true;
            int tries = 0;
            System.Console.WriteLine("LETS PLAY GUESS A NUMBER BETWEEN 1-100");
            while (playing)
            {
                System.Console.WriteLine($"So far you have guessed: {tries} time(s)");
                tries++;
                System.Console.Write("Guess: ");
                string strGuess = Console.ReadLine();
                int guess;
                if (!Int32.TryParse(strGuess, out guess) || guess < 1 || guess > 100)
                {
                    System.Console.WriteLine("What a terrible guess dum dum, that guess still counts");
                    continue;
                }
                if (number == guess)
                {
                    System.Console.WriteLine("Winner Winner Chicken Dinner");
                    System.Console.WriteLine($"It only took {tries} guesses!");
                    System.Console.WriteLine("Play again? (press 'y' to continue or any other key to exit)");
                    ConsoleKeyInfo decision = Console.ReadKey();
                    if (decision.KeyChar == 'y')
                    {
                        tries = 0;
                        number = rnd.Next(1, 101);
                        Console.Clear();
                        continue;
                    }
                    playing = false;
                }
                else if (number > guess)
                {
                    System.Console.WriteLine("Guess Higher Doofus");
                }
                else
                {
                    System.Console.WriteLine("Guess Lower Dingbat");
                }

            }
        }
    }
}
