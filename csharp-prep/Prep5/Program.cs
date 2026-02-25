using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }

        static void PrintMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string UserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static int UserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNum = int.Parse(Console.ReadLine());

            return userNum;
        }
        static int UserBirthday()
        {
            Console.Write("Please enter the year you were born: ");
            int birthYear = int.Parse(Console.ReadLine());

            return birthYear;
        }
        // static float SquareNum(int userNum);
}