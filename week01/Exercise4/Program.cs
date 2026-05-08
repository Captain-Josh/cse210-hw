using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of number, type 0 when finished: ");
        List<int> numbers = new List<int>();
        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if(userInput !=0)
            {
                numbers.Add(userInput);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if(number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}