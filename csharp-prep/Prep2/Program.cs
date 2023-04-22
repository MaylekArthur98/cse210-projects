using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percent? ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (grade >=80 && grade < 90)
        {
             Console.WriteLine("You got an B!");
        }
        else if (grade >=70 && grade < 80)
        {
             Console.WriteLine("You got an C!");
        }
        else if (grade >=60 && grade < 70)
        {
             Console.WriteLine("You got an D!");
        }
        else 
        {
             Console.WriteLine("You got an F.");
        }
        if (grade >= 70)
        {
            Console.WriteLine("You've passed Congrats!");
        }
        else
        {
            Console.WriteLine("You've failed, try again.");
        }
    }
}