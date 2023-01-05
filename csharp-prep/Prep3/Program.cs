using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool exiting = false;

        do 
        {
            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());
            if(userGuess > number)
            {
                Console.WriteLine("Lower"); 
            }
            else if (userGuess < number)
            {
                Console.WriteLine("Higher"); 
            }
            else
            {
                exiting = true;
                Console.WriteLine("You guessed it!");
            }
        }
        while (!exiting);
    }
}