using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Please welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write ("Please enter your name: ");
        string yourName = Console.ReadLine();
        return yourName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int yourNumber = int.Parse(Console.ReadLine());
        return yourNumber;
    }
    static int SquareNumber(int yourNumber)
    {
        int square = yourNumber * yourNumber;
        return square;
    }
    static void DisplayResult(string yourName, int square)
    {
        Console.WriteLine($"{yourName}, the sqaure of your number is {square}");
    }

}