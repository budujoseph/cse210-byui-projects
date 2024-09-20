using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string gradeLetter = "";

        if (grade >= 90)
        {
            // Console.Write("You got a grade A");
            gradeLetter = "A";
        }

        else if ( grade >= 80)
        {
            // Console.Write("You got a grade B");
            gradeLetter = "B";
        }

        else if (grade >= 70)
        {
            // Console.Write("You got a grade C");
            gradeLetter = "C";
        }

        else if (grade >= 60)
        {
            // Console.Write("You got a grade D");
            gradeLetter = "D";
        }

        
        else
        {
             // Console.Write("You got a grade F");
             gradeLetter = "F";
        }

        // Console.WriteLine ($"Your grade is: {gradeLetter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, You passed the test");
        }

        else 
        {
            Console.WriteLine("Sorry You Failed, better luck next time.");
        }

        int lastDigit = grade % 10;
        string sign = "";
    

        // if (lastDigit >= 7)
        // {
        //     sign = "+";
        // }

        // else if (lastDigit < 3)
        // {
        //     sign = "-";
        // }

        // else
        // {
        //     sign = "";
        // }

        if (gradeLetter == "A" || gradeLetter == "F")
        {
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        else
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }

            else if (lastDigit > 3)
            {
                sign = "-";
            }

        }


        Console.WriteLine($"Your Final Grade is: {gradeLetter}{sign}");
    }
}