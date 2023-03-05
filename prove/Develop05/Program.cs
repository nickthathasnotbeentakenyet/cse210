using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    { 
    List<string> goals = new List<string>();
    const string pointsFile = "points.txt";
    string filename = "";
    string toComplete;
    int totalPoints = getTotalPoints(pointsFile);
    while(true){  
        Console.Clear(); 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"Progress: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(totalPoints);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" points");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine("Menu:\n1. Create\n2. Display\n3. Save\n4. Load\n5. Record\n6. Delete\n7. Quit");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(":> ");
        string menuEntry = Console.ReadLine();
        Console.ResetColor();
        switch (menuEntry){
            case "1": // create
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("Specify goal type:\n1. Simple goal\n2. eternal goal\n3. Checklist goal");
                Console.Write(":> ");
                string userGoal = Console.ReadLine();
                Console.ResetColor();
                switch (userGoal){
                    case "1": // simple
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Name: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string name = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Description: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string description = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Points: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string points = Console.ReadLine();
                        Console.ResetColor();
                        Simple simple = new Simple("Simple",false, name, description, Int32.Parse(points));
                        string sG = simple.CreateGoal();
                        goals.Add(sG);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("[success] goal created.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    case "2": // eternal
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Name: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        name = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Description: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        description = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Points: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        points = Console.ReadLine();
                        Console.ResetColor();
                        Eternal eternal = new Eternal("Eternal",false, name, description, Int32.Parse(points));
                        string eG = eternal.CreateGoal();
                        goals.Add(eG);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("[success] goal created.");
                        Console.ReadKey();
                        break;
                    case "3": // checklist
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Name: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        name = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Description: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        description = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Points: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        points = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Bonus: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string bonus = Console.ReadLine();
                        while(true){
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            System.Console.Write("Steps to complete: ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            toComplete = Console.ReadLine();
                            if(Int32.Parse(toComplete) > 0)break;
                            else {
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.WriteLine("[error] must be higher than 0");
                            }
                        }
                        Console.ResetColor();
                        int completed = 0;
                        Checklist checklist = new Checklist("Checklist",false, name, description, Int32.Parse(points), Int32.Parse(bonus), completed, Int32.Parse(toComplete));
                        string cG =  checklist.CreateGoal();
                        goals.Add(cG);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("[success] goal created.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("[error] invalid input");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
                break;
            case "2": // display
                if (goals.Count > 0) {DisplayGoals(goals);}
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("[error] nothing to display");
                    Console.ResetColor();
                    }
                Console.ReadKey();
                break;
            case "3": // save
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.Write("File: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                filename = Console.ReadLine();
                Console.ResetColor();
                if (goals.Count > 0){
                    try{
                        SaveGoals(goals, filename);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("[success] file saved.");
                    }
                    catch{
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("[error] not saved..");
                    }
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.Write("[warning] You are about to clear the file. Proceed? [y/n]: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string answer = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (answer == "y"){
                        SaveGoals(goals, filename);
                        System.Console.WriteLine("[success] file cleared.");
                    }
                    else{
                        System.Console.WriteLine("Consider creating goals first");
                    }
                    Console.ResetColor();
                }
                Console.ReadKey();
                break;
            case "4": // load
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.Write("File: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                filename = Console.ReadLine();
                try{
                    goals = LoadGoals(filename);
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("[success] file loaded.");
                }
                catch{
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("[error] file not loaded..");
                }
                Console.ResetColor();
                Console.ReadKey();
                break;
            case "5": // record
                if (goals.Count > 0){
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    System.Console.WriteLine("Which one did you accomplish?");
                    DisplayGoals(goals);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Console.Write(":> ");
                    try{
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string accomplish = Console.ReadLine();
                        int isComplete = IsComplete(goals, Int32.Parse(accomplish));
                        if (isComplete == 1){
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("[error] this goal is already complete");
                            System.Console.WriteLine("Consider deleting it");
                        }
                        else if (isComplete == -1){
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write("[error] ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.Write($"'{accomplish}'");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine(" doesn't exist..");
                        }
                        else{
                            int points = Update(goals, Int32.Parse(accomplish), filename);
                            totalPoints += points;
                            updatePoints(pointsFile,totalPoints);
                            goals = LoadGoals(filename);
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("[success] information updated");
                        }
                        Console.ResetColor();
                    }
                    catch{
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("[error] invalid input..");
                        Console.ResetColor();
                    }
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("[error] consider loading first");
                    Console.ResetColor();
                }
                Console.ReadKey();
                break;
            case "6": // delete
                if (goals.Count > 0){
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Which goal do you want to delete?: ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.ResetColor();
                    Console.ResetColor();
                    DisplayGoals(goals);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Console.Write(">: ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    int toDelete = Int32.Parse(Console.ReadLine());
                    Console.ResetColor();
                    if(deleteGoal(toDelete, filename)){
                        goals = LoadGoals(filename);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[success] goal has been removed.");
                        Console.ResetColor();
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[error] can't be deleted...");
                        Console.ResetColor();
                    }
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[error] consider loading first.");
                    Console.ResetColor();
                }
                Console.ReadKey();
                break;
            case "7": // exit
                System.Environment.Exit(0);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("[error] invalid menu entry");
                Console.ResetColor();
                Console.ReadKey();
                break;
            }
        }
    }
    static void DisplayGoals(List<string> goals){
        int count = 1;
        foreach(string goal in goals){
            string[] parts = goal.Split(" | ");
            string indicator;
            if (parts[1] == "True"){
                indicator = "[x]";
            }
            else indicator = "[ ]";
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (parts[0] == "Checklist"){
                System.Console.Write($"{count}.");
                if(indicator.Contains("[x]")) Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(indicator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" {parts[2]} ({parts[3]}) -- Complete: {parts[6]}/{parts[7]}");
            }
            else {
                System.Console.Write($"{count}.");
                if(indicator.Contains("[x]")) Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(indicator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" {parts[2]} ({parts[3]})");
            }
            Console.ResetColor();
        count++;  
        }
    } 
    static void SaveGoals(List<string> goals, string filename){
        using (StreamWriter sw = new StreamWriter(filename, false))
        {
            foreach (string goal in goals)
            {
                sw.WriteLine(goal);
            }
        }
    }
    static List<string> LoadGoals(string filename){
        string[] goals = File.ReadAllLines(filename);
        List<string> goalsList = new List<string>();
        foreach(string line in goals){
            goalsList.Add(line);
        }
        return goalsList;
    }
    static int IsComplete(List<string> goals, int accomplished){
        int count = 1;
        foreach(string goal in goals){
            if (count == accomplished){
                string[] parts = goal.Split(" | ");
                if (parts[1] == "True") return 1;
                else return 0;
            }
            count++;
        };  
        return -1;
    }
    static int Update(List<string> goals, int accomplished, string filename){
        int count = 1;
        List<string> tempList = new List<string>();
        string newString;
        foreach(string goal in goals){
            if (count == accomplished){
                string oldString = goal;
                string[] parts = goal.Split(" | ");
                int pointsToAdd = Int32.Parse(parts[4]);
                if (parts[0] == "Simple"){
                    newString = $"Simple | True | {parts[2]} | {parts[3]} | {parts[4]}";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write($"You just got another ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{pointsToAdd}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" points for accomplishing the goal");
                    Console.ResetColor();
                }
                else if(parts[0] == "Eternal"){
                    newString = $"Eternal | {parts[1]} | {parts[2]} | {parts[3]} | {parts[4]}";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write($"You just got another ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{pointsToAdd}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" points for accomplishing the goal");
                    Console.ResetColor();
                }
                else{
                    int completed = Int32.Parse(parts[6]);
                    int toComplete = Int32.Parse(parts[7]);
                    completed++;
                    if (completed < toComplete){
                        newString = $"Checklist | {parts[1]} | {parts[2]} | {parts[3]} | {parts[4]} | {parts[5]} | {completed} | {toComplete}";
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.Write($"You just got another ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{pointsToAdd}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" points for accomplishing the goal");
                        Console.ResetColor();
                    }
                    else{
                        newString = $"Checklist | True | {parts[2]} | {parts[3]} | {parts[4]} | {parts[5]} | {completed} | {toComplete}";
                        int bonus = Int32.Parse(parts[5]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.Write($"You just got another ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{pointsToAdd}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" points for accomplishing the goal");
                        System.Console.Write($"Congrats! You got ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(bonus); 
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" points as a bonus for completing the goal");
                        Console.ResetColor();
                        pointsToAdd += bonus;
                    }
                }
            string[] lines = File.ReadAllLines(filename);
            lines[accomplished - 1] = newString;
            File.WriteAllLines(filename, lines);
            return pointsToAdd;
            }
            count++;
        };
        return 0;
    }
    public static int getTotalPoints(string filename)
    {
        if (File.Exists(filename)){
            string line = File.ReadLines(filename).First();
            return Int32.Parse(line);
        }
        else return 0;
    }
    public static void updatePoints(string filename, int points)
    {
        using (StreamWriter sw = new StreamWriter(filename, false)){
                    sw.WriteLine(points.ToString());
                }
    }
    public static bool deleteGoal(int lineNum, string filename){
        var tempFile = Path.GetTempFileName();
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (lines.Count() < lineNum || lineNum == 0){
            return false;
        }
        else{
            List<string> linesToKeep = new List<string>();
            int c = 0;
            foreach(string line in lines){
                ++c;
                if(c == lineNum){continue;}
                linesToKeep.Add(line);
            }
            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete(filename);
            File.Move(tempFile, filename);
            return true;
        }
    }
}

// COMMENT: ----------------------------------------------------------------------------------
/*
1. Added 'delete' functionality
2. If user attempts to save to file when there is nothing in memory it will warn 
if user wants to clear out the file. If not -> operation canceled and advice is given
3. Program warns if user tries to set the number of times to accomplish a checklist goal to zero
4. Other informative messages
5. Colorized i/o 
*/
// TODO: reset progress on a goal(simple -> true to false; checklist -> false & steps to zero)
