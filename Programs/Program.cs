using System.ComponentModel.Design;

namespace Programs
{
    internal class Progrm
    {
        static void Main(string[] args)
        {
            string[] question =
            {
                "What is the capital of France?\nA) Paris\nB) London\nC) Rome\nD) Madrid",
                "Which planet is known as the Red Planet?\nA) Earth\nB) Mars\nC) Venus\nD) Jupiter",
                "What is 2 + 2?\nA) 3\nB) 4\nC) 5\nD) 6",
                "What is the largest mammal?\nA) Elephant\nB) Blue Whale\nC) Giraffe\nD) Shark",
                "Who wrote 'Romeo and Juliet'?\nA) Charles Dickens\nB) William Shakespeare\nC) Mark Twain\nD) J.K. Rowling"
            };

            char[] correctAnswers = { 'A', 'B', 'B', 'B', 'B' };
            int score = 0;

            bool playAgain = true;

            while (playAgain)
            {
                score = 0;  // Reset score for each new game
                for (int i = 0; i < question.Length; i++)
                {
                    Console.Clear();  // Clear the console to make it neat
                    Console.WriteLine(question[i]);
                    Console.WriteLine("Your answer (A/B/C/D):");

                    char answer = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();  // Move to the next line

                    if (answer == correctAnswers[i])
                    {
                        Console.WriteLine("Correct!\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n");
                    }
                }

                // Display the final score
                Console.WriteLine($"Final score: {score} out of 5");
                switch (score)
                {
                    case 5:
                        Console.WriteLine(" You got all the answers right!");
                        break;

                    case 4:
                        Console.WriteLine("Great job!");
                        break;

                    case 3:
                        Console.WriteLine("Good job!");
                        break;

                    case 2:
                        Console.WriteLine("Not bad ");
                        break;

                    case 1:
                        Console.WriteLine("Try again!");
                        break;

                    default:
                        Console.WriteLine("Better luck next time!");
                        break;
                }

                // Ask if the user wants to play again
                Console.WriteLine("\nDo you want to play again? (Y/N): ");
                char playAgainAnswer = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (playAgainAnswer != 'Y')
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }
    }
}

