using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1, score2, score3, score4;

            Console.WriteLine("Enter your first test score.");
            score1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your second score?");
            score2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your third score?");
            score3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your fourth score?");
            score4 = Convert.ToDouble(Console.ReadLine());

            double result = (score1 + score2 + score3 + score4) / 4;

            Console.WriteLine("The average of your scores is " + result);

        }
    }
}
