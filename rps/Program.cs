using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Please enter your choice rock (1), paper (2), or scissors (3):");
            string userChoice = Console.ReadLine();

            Random computerChoice = new Random();
            int computerChoiceInt = computerChoice.Next(1, 4);
            switch (computerChoiceInt)
            {
                case 1:
                    Console.WriteLine("Computer chose rock");
                    break;
                case 2:
                    Console.WriteLine("Computer chose paper");
                    break;
                case 3:
                    Console.WriteLine("Computer chose scissors");
                    break;
            }

            if (userChoice == "1")
            {
                Console.WriteLine("You chose rock");
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("You chose paper");
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("You chose scissors");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            if (userChoice == "1" && computerChoiceInt == 1)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == "1" && computerChoiceInt == 2)
            {
                Console.WriteLine("Computer wins!");
            }
            else if (userChoice == "1" && computerChoiceInt == 3)
            {
                Console.WriteLine("You win!");
            }
            else if (userChoice == "2" && computerChoiceInt == 1)
            {
                Console.WriteLine("You win!");
            }
            else if (userChoice == "2" && computerChoiceInt == 2)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == "2" && computerChoiceInt == 3)
            {
                Console.WriteLine("Computer wins!");
            }
            else if (userChoice == "3" && computerChoiceInt == 1)
            {
                Console.WriteLine("Computer wins!");
            }
            else if (userChoice == "3" && computerChoiceInt == 2)
            {
                Console.WriteLine("You win!");
            }
            else if (userChoice == "3" && computerChoiceInt == 3)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }3


        }
    }
}