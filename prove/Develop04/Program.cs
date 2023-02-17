using System;

class Program
{
    static void Main(string[] args)
    {   
        // variables
        List<string> menuItems = new List<string>{
            "Start breathing activity", 
            "Start reflecting activity",
            "Start listing activity",
            "Quit"
        };
        object [,] actColl = new object [3,2] {
            {"Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."},
            {"Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."},
            {"Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."}
        };
        List<string> refPrompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        List<string> questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        List<string> listPrompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        int thinkingTime = 12;
        int duration = 0;
        int countActivitiesDone = 0;

        // Menu & Colors
        Menu menu = new Menu(menuItems);
        Colors c = new Colors();
        while(true){
            Console.Clear();
            menu.ShowMenu();
            Console.Write($"{c.blue}:> {c.reset}");
            string userAnswer = menu.GetUserMenu();

            // Activities
            switch(userAnswer){
                case "1":
                    Console.Clear();
                    Activity act1 = new Activity((string)actColl[0,0],(string)actColl[0,1],duration);
                    act1.GetStartingMsg(); 
                    duration = act1.GetDuration();
                    act1.setDuration = duration;
                    Console.Clear();
                    Console.WriteLine($"{c.yellow}Get ready...{c.reset}\n");
                    Breathing breathing = new Breathing((string)actColl[0,0],(string)actColl[0,1],duration);
                    breathing.PrintActivity();
                    Console.WriteLine(act1.GetEndingMsg());
                    act1.ShowAnimation(5);
                    countActivitiesDone++;
                    break;
                case "2":
                    Console.Clear();
                    Activity act2 = new Activity((string)actColl[1,0],(string)actColl[1,1],duration);
                    act2.GetStartingMsg(); 
                    duration = act2.GetDuration();
                    act2.setDuration = duration;
                    Console.Clear();
                    Console.WriteLine($"{c.yellow}Get ready...{c.reset}\n");
                    Reflection reflection = new Reflection((string)actColl[1,0],(string)actColl[1,1],duration,refPrompts,questions,thinkingTime);
                    reflection.PrintReflection();
                    Console.WriteLine(act2.GetEndingMsg());
                    act2.ShowAnimation(5);
                    countActivitiesDone++;
                    break;
                case "3":
                    Console.Clear();
                    Activity act3 = new Activity((string)actColl[2,0],(string)actColl[2,1],duration);
                    act3.GetStartingMsg(); 
                    duration = act3.GetDuration();
                    act3.setDuration = duration;
                    Console.Clear();
                    Console.WriteLine($"{c.yellow}Get ready...{c.reset}\n");
                    Listing listing = new Listing((string)actColl[2,0],(string)actColl[2,1], duration,listPrompts);
                    listing.PrintListing();
                    Console.WriteLine(act3.GetEndingMsg());
                    act3.ShowAnimation(5);
                    countActivitiesDone++;
                    break;
                case "4":
                    string acts = "";
                    if (countActivitiesDone == 1) acts = "activity";
                    else acts = "activities";
                    PrintProgress(); 
                    Console.WriteLine($"\n{c.yellow}Stats: {c.blue}You have completed{c.reset} {c.red}{countActivitiesDone}{c.blue} {acts} {c.reset}");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine($"{c.red}Error: wrong input.{c.reset} {c.blue}Press any key to continue.{c.reset}");
                    Console.ReadKey();
                    break;    
            }

            static void WriteProgressBar(int percent, bool update = false)
            {
                const char _block = '■';
                const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
                if(update)
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(_back);
                Console.Write("[");
                var p = (int)((percent / 10f)+.5f);
                for (var i = 0;i<10;++i)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (i >= p)
                        Console.Write(' ');
                    else
                        Console.Write(_block);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("] ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,3:##0}%", percent); 
                Console.ResetColor();   
            }
            static void PrintProgress(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Getting stats...");
            WriteProgressBar(0);
            for (var i = 0; i <= 100; ++i)
                {
                    WriteProgressBar(i,true);
                    Thread.Sleep(50);
                }
            }
        }
    }
}

// ===================
// Creativity comment:
// ===================
/*
1. Kept track of number of activities done
2. Visuals: additional progress animation, colors
*/
