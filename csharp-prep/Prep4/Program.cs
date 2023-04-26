using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        int sum = 0;
        int bigNum = 0;
        int smolNum = 0;
        foreach (var item in numbers)
        {
           sum += item; 
           if (item > bigNum)
           {
            bigNum = item;
           }
           if (item < smolNum)
           {
            smolNum = item;
           }
        }
        int average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Largest number is: {bigNum}");
        Console.WriteLine($"The Smallest number is: {smolNum}");

    }
    
}