using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command != "y")
            {
                Console.WriteLine("Input your score (0-100):");
                string scoreInput = Console.ReadLine();
                try
                {
                    int score = Int32.Parse(scoreInput);
                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("Error: Score must be between 0 - 100.");
                    }
                    else
                    {
                        string grade = "";

                        if (score >= 80) grade = "A";
                        else if (score >= 75) grade = "B+";
                        else if (score >= 70) grade = "B";
                        else if (score >= 65) grade = "C+";
                        else if (score >= 60) grade = "C";
                        else if (score >= 55) grade = "D+";
                        else if (score >= 50) grade = "D";
                        else grade = "F";

                        Console.WriteLine("Score: " + scoreInput + " -> Grade: " + grade);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You input wrong number format.");
                }
                Console.WriteLine("Do you want to exit?[y/n]");
                command = Console.ReadLine();
            }
        }
    }
}
