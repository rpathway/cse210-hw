using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbers = new List<float>();
        float largest = 0;
        float smallest = 9999;
        float inputNumber;
        float sum = 0;
        float average;

        do
        {
            Console.Write("Enter number: ");
            inputNumber = float.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        } while (inputNumber != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
            if (numbers[i] < smallest && !(numbers[i] <= 0))
            {
                smallest = numbers[i];
            }
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}