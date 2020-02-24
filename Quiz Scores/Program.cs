using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuizzes = 5;
            double[] quizzes = new double[numberOfQuizzes];

            quizzes = DisplayGetQuizScores();
            DisplayQuizScores(quizzes);
            DisplayAverage(quizzes);
        }

        static void DisplayAverage(double[] quizzes) 
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Average Score");
            Console.WriteLine();

            Console.WriteLine($"Average: {quizzes.Average()}");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayQuizScores(double[] quizzes) 
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Quiz Scores");
            Console.WriteLine();

            //
            // display scores
            //
            for (int index = 0; index < quizzes.Length; index++)
            {
                Console.WriteLine($"Quiz {index + 1}: {quizzes[index]}");
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static double[] DisplayGetQuizScores() 
        {
            int numberOfQuizzes = 5;
            double tempNumber;
            double[] quizzes = new double[numberOfQuizzes];

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Emter Scores");
            Console.WriteLine();

            //
            // get scores from user
            //
            for (int index = 0; index < numberOfQuizzes; index++)
            {
                Console.Write($"Quiz {index + 1}: ");
                double.TryParse(Console.ReadLine(), out tempNumber);
                quizzes[index] = tempNumber;
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            return quizzes;
        }
    }
}
