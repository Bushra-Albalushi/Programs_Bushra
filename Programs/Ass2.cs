using System.ComponentModel.Design;

namespace Programs
{
    internal class Program
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

            for (int i =0; i < question .Length; i++)
            {
                Console.WriteLine(question[i]);
                Console.WriteLine("Your answer (A/B/C/D)");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (uesrAnswer == correctAnswers[i]) ;

                {
                    Console.WriteLine("correct !\n");
                    score++;
                }
               
                    {
                    Console.WriteLine("Wrong!\n");
                    Console.WriteLine($"\nFinal score: {score} OutOfMemoryException of 5");
                    switch (score)
                    {
                        case 1:
                            Console.WriteLine("very good!");
                            break;

                        case 2:
                        case 3:
                            Console.WriteLine("Good!");
                            break;
                            Console.WriteLine("sorry !you failed");
                            break;
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
}
