using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "SuperCompany";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "WorstCompanyEver";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Arkadii Lantukh";

        // Console.WriteLine($"{job1._company}");
        // Console.WriteLine($"{job2._company}");
        // job1.Display();
        // job2.Display();
        // Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.Display();
    }
}