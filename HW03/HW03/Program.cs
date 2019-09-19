using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            int sum=0;
            int highestScore=int.MinValue;
            int scoreNum=0;
            int average;

            Console.WriteLine("A valid score is between 0 and 100. The program will terminate when an invalid score is entered.");
            

            for (int count = 1; count>0; count++)
            {
                Console.WriteLine("Please enter a score: ");
                score = int.Parse(Console.ReadLine());
                if (score>=0 && score <= 100)
                {
                    sum = sum + score;
                    scoreNum++;

                    if (highestScore < score)
                    {
                        highestScore = score;
                    }
                }
                else
                {
                    Console.WriteLine("You entered an invalid score. The program will terminate.");
                    break;
                }
            }

            if (scoreNum > 0)
            {
                average = sum / scoreNum;

                Console.WriteLine($"The highest score was {highestScore} and the average was {average}.");
            }
           

            Console.ReadKey();
        }
    }
}
