using System;

class Program
{
    static void Main(string[] args)
    {
        //There are 3 parts to this task:

        //Part 1: Ask the user for the magic number: 
        //Console.Write("What is the magic number?" );
        //int magicNumber = int.Parse(Console.ReadLine());
        // Then ask him to guess the magic number

        //Part 2: Add a loop that keeps looping until the
        // the guess matches the magic number
        
        //Part 3: Generate a random number from computer instead of
        //asking the user to supply the magic number

        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
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