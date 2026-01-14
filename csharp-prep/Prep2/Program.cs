using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A" ;
        }
        else if(grade >= 80)
        {
            letter = "B" ;
        }
        else if(grade >= 70)
        {
            letter = "C" ;
        }
        else if(grade >= 60)
        {
            letter = "D" ;
        }
        else if(grade < 60)
        {
            letter = "F" ;
        }
        Console.WriteLine($"Your grade is: {letter}");

        if(grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time :(");
        }
    }
}