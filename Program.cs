using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            int playerScore = 0;
            int computerScore = 0;
            StartGame(playerScore, computerScore);
        }

        static void StartGame(int playerScore, int computerScore)
        {
            if (playerScore < 3 && computerScore < 3)
            {
                Console.Write($@"
---------------------------
| Player: {playerScore} | Computer: {computerScore} |
---------------------------
What would you like to throw?
1) Rock
2) Paper
3) Scissors
");

                PlayGame(playerScore, computerScore);
            }
            else if (computerScore == 3 && playerScore != 3)
            {
                Console.WriteLine("Game Over!");
                Console.WriteLine("Computer WINS -- Better Luck Next Time");
            }
            else if (playerScore == 3 && computerScore != 3)
            {
                Console.WriteLine("Game Over!");
                Console.WriteLine("You Are The WINNER WINNER CHICKEN DINNER!");
            }
            else
            {
                Console.WriteLine("Tie Game... better luck next time!");
            }
        }

        static void PlayGame(int playerScore, int computerScore)
        {
            int playerChoice = int.Parse(Console.ReadLine());
            Console.WriteLine($"You chose: {playerChoice}");
            Random r = new Random();
            int computerChoice = r.Next(1, 3);
            Console.WriteLine($"Computer Chose: {computerChoice}");



            if (playerChoice == 1)
            {
                Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
            }
            else if (playerChoice == 2)
            {
                Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
            }
            else if (playerChoice == 3)
            {
                Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
                ");
            }
            else
            {
                Console.WriteLine("ALERT: Only enter a number 1, 2 or 3.");
                PlayGame(playerScore, computerScore);
            }

            Console.WriteLine();
            Console.WriteLine("VS.");
            Console.WriteLine();

            if (computerChoice == 1)
            {
                Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
            }
            else if (computerChoice == 2)
            {
                Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
            }
            else if (computerChoice == 3)
            {
                Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
                ");
            }


            if (computerChoice == playerChoice)
            {
                Console.WriteLine("TIE!");
                computerScore++;
                playerScore++;
                StartGame(playerScore, computerScore);
            }
            else if (computerChoice == 1 && playerChoice == 2)
            {
                Console.WriteLine("Paper beats rock... 1 point player!");
                playerScore++;
                StartGame(playerScore, computerScore);
            }
            else if (computerChoice == 2 && playerChoice == 1)
            {
                Console.WriteLine("Paper beats Rock... 1 point Computer!");
                computerScore++;
                StartGame(playerScore, computerScore);
            }
            else if (computerChoice == 3 && playerChoice == 1)
            {
                Console.WriteLine("Rock beats Scissors... 1 point player!");
                playerScore++;
                StartGame(playerScore, computerScore);
            }
            else if (computerChoice == 3 && playerChoice == 2)
            {
                Console.WriteLine("Scissors beats Paper... 1 point Computer!");
                computerScore++;
                StartGame(playerScore, computerScore);
            }
            else if (computerChoice == 1 && playerChoice == 3)
            {
                Console.WriteLine("Rock beats scissors... 1 point Computer!");
                computerScore++;
                StartGame(playerScore, computerScore);
            }
            else if (computerChoice == 2 && playerChoice == 3)
            {
                Console.WriteLine("Scissors beats paper... 1 point Player!");
                playerScore++;
                StartGame(playerScore, computerScore);
            }


        }


    }
}
