using System;

namespace Scores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string message = $"\nWelcome {uName}. Today is {date}";
            Console.WriteLine(message);

            string path = @"C:\Users\lskys\source\repos\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;
            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine($"\nScore: {line}");
                tScore += double.Parse(line);
            }
            Console.WriteLine($"\nTotal of {lines.Length} scores is {tScore}");
            Console.WriteLine($"\nAverage score is {tScore / lines.Length}");

            Console.ReadLine();
        }
    }
}
