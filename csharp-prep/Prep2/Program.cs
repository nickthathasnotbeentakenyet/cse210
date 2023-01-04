using System;

class Program
{
    static void Main(string[] args)
    {
        // getting user input
        Console.Write("What is the grade percentage? ");
        string userInput = Console.ReadLine();
        float gradePercentage = float.Parse(userInput);
        // variables to hold grade letter and sign
        string letter, sign;
        //  passed sections
        if (gradePercentage >= 70)
        {
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else
            {
                letter = "C";
            }
            Console.WriteLine("Congratulations! You successfuly passed this course!");
        }  
        //  failed section
        else
        {    
            if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";   
            }    
            Console.WriteLine("Sorry, looks like you did not succeed in this class.");
        }

        //  adding sign
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3 && gradePercentage % 10 != 0)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }  
        //  removing sign from A+ and F
        if (gradePercentage >= 93 || gradePercentage < 60)
        {
            sign = "";
        }
        // printing the grade and its sign
        Console.WriteLine($"Your grade is {letter}{sign}"); 
    }
}