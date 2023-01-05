using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string uName = PromptUserName();
        int uNumber = PromptUserNumber();
        int sqNumber = SquareNumber(uNumber);
        DisplayResult(uName,sqNumber);
    }
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static void DisplayResult (string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}