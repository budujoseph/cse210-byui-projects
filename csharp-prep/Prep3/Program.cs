using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        
        // Console.Write("What is your guess number? ");
        // int guessNumber = int.Parse(Console.ReadLine());

        int guessNumber = -1;
        
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Lower");
            }
        }

        // if (guessNumber == number)
        // {
        //     Console.WriteLine("You guessed it!");
        // }

        // else if (guessNumber < number)
        // {
        //     Console.WriteLine("Higher");
        // }

        // else
        // {
        //     Console.WriteLine("Lower");
        // }
    }
}