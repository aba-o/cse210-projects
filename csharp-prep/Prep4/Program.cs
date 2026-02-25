using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int num = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        
        while (num != 0)
        {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        num = int.Parse(number);

        if (num != 0)
            {
                numbers.Add(num);
            }
        }
        
        int sum = 0;
        foreach (int numeral in numbers)
        {
            sum += numeral;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        float average = 0;
        foreach (int numeral in numbers)
        {
            average = sum/numbers.Count;
        }
        Console.WriteLine($"The average is: {average:F2}");
        
        int largestNum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The Max is: {largestNum}");
    }
}