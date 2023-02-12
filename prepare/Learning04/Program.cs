using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        System.Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string homework = mathAssignment.GetHomeworkList();
        summary = mathAssignment.GetSummary();
        System.Console.WriteLine(summary);
        System.Console.WriteLine(homework);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        System.Console.WriteLine(writingAssignment.GetSummary());
        System.Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}