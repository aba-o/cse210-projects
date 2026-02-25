using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomNum = new Random();
        int magicNumber = randomNum.Next(1,101);

        int guess = -1;

        while (guess != magicNumber){
            Console.Write("What is your guess? ");
            string guessNum = Console.ReadLine();
            guess = int.Parse(guessNum);
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
    }
    }
}