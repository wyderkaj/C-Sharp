using System;

namespace Simple_Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are about to play dice against the computer.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You will fight 4 battles.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Whoever wins more battles wins the war.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Good luck!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            do
            {
                int playerRandomNum;
                int computerRandomNum;

                int playerPoints = 0;
                int computerPoints = 0;

                Random random = new Random();

                

                for (int i = 0; i < 4; i++)
                {

                    Console.WriteLine("Press any key to roll the dice.");
                    Console.WriteLine();
    
                    Console.ReadKey();

                    playerRandomNum = random.Next(1, 7);
                    Console.WriteLine("You rolled a " + playerRandomNum);

                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(1000);

                    computerRandomNum = random.Next(1, 7);
                    Console.WriteLine("Computer rolled a " + computerRandomNum);
                    Console.WriteLine();

                    if (playerRandomNum > computerRandomNum)
                    {
                        playerPoints++;
                        Console.WriteLine("You win this round!");
                    }
                    else if (playerRandomNum < computerRandomNum)
                    {
                        computerPoints++;
                        Console.WriteLine("Computer wins this round!");
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                    }

                    Console.WriteLine("The score is now: Player: " + playerPoints + "- Computer: " + computerPoints + ".");
                    Console.WriteLine();
                }

                if (playerPoints > computerPoints)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerPoints < computerPoints)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                }

                Console.WriteLine();
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
                Console.WriteLine();

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
        
    }
}
