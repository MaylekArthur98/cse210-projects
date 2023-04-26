using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magic = int.Parse(Console.ReadLine());
        int number = int.Parse("");
        while (number != magic)
        {    
            Console.Write("What is your guess? ");
            int number = int.Parse(Console.ReadLine());
            if (magic > number)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < number)
            {
            Console.WriteLine("Lower");
            }
            else if (magic == number)
            {
            Console.WriteLine("You guessed it!");
            }
        }
    }
}