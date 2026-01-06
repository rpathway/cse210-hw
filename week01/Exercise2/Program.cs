using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();

        int gradeNumber = int.Parse(gradePercent);
        int gradeSignNumber = gradeNumber % 10; // Last digit in grade percentage
        string letter;
        string gradeSign = "";

        // Grade sign
        if (gradeSignNumber >= 7)
        {
            gradeSign = "+";
        }
        else if (gradeSignNumber < 3)
        {
            gradeSign = "-";
        }

        // Grade percentage to number
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Edge cases; Only A & A- no F+ or F-
        if ((letter == "A" && gradeSign == "+") || letter == "F")
        {
            gradeSign = "";
        }

        Console.WriteLine($"{letter}{gradeSign}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, you've passed the class!");
        }
        else
        {
            Console.WriteLine("Oof! You didn't pass the class, you can always try again!");
        }
    }
}