using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // List where the user numbers will be added
        List<int> numbers = new List<int>();
        
        //Use of while loop to loop the user's number input process, 
        // which stops if the user enters 0
        int userNumber = -1;
        
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");

            userNumber = int.Parse(Console.ReadLine());

            //The if statement is used to add a number to the list that is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        //Part 1: Compute the total of the numbers in the list
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        //Part 2: Compute the average of the numbers in the list
        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        //Part 3: Find the largest number in the list

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                // if in the list the number that is greater than 
                // the largest number will be the new max!
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");    

    }
}