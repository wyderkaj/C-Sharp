using System;

namespace number_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            Console.WriteLine("Hi! Welcome to the guessing game.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Computer is going to pick a number between 1 and 100.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your task is to guess that number.");
            System.Threading.Thread.Sleep(1000);
            

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine();
                    Console.WriteLine("Guess a number: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine();
                Console.WriteLine("Correct number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("It took you " + guesses + " guesses");
                Console.WriteLine();
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
