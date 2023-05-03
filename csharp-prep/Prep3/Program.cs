using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 200);
        
        int guess = -1;
        while (magic != guess)
        {    
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
    }
}