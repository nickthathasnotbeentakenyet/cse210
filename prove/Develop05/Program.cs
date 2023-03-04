using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {    
        string menuItem, goalName, description;
        string filename = "";
        const string pointsFile = "points.txt";
        int points, toComplete;
        int totalPoints = getTotalPoints(pointsFile);
        List<string> goalsList = new List<string>();
        List<string> goalsDisplayList = new List<string>();
        List<string> goalInfo = new List<string>();
        while(true){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Total Points: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(totalPoints);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" points");
            PrintMenu();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(">: ");
            Console.ResetColor();
            menuItem = Console.ReadLine();
            switch (menuItem){
                case "1": // new goal
                    PrintGoalTypes();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Goal type: ");
                    Console.ResetColor();
                    string goalType = Console.ReadLine();
                    switch (goalType){
                        case "1": // simple goal
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Goal name: ");
                            Console.ResetColor();
                            goalName = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Goal description: ");
                            Console.ResetColor();
                            description = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Amount of points associated with the goal: ");
                            Console.ResetColor();
                            try{
                                points = Int32.Parse(Console.ReadLine());
                                Simple simple = new Simple(goalName,description,points,false);
                                string simpleString = simple.GetStringRepresentation();
                                string simpleDisplay = simple.CreateSimple(); 
                                goalsList.Add(simpleString); 
                                goalsDisplayList.Add(simpleDisplay);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[success]");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(" simple goal created!");
                                Console.ResetColor();
                            }
                            catch{
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[error]");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" invalid input! Goal was not created!");
                                Console.ResetColor();
                            };
                            Console.ReadKey();
                            break;
                        case "2": // eternal goal
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Goal name: ");
                            Console.ResetColor();
                            goalName = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Goal description: ");
                            Console.ResetColor();
                            description = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Amount of points associated with the goal: ");
                            Console.ResetColor();
                            try{
                                points = Int32.Parse(Console.ReadLine());
                                Eternal eternal = new Eternal(goalName, description, points);
                                string eternalString = eternal.GetStringRepresentation();
                                string eternalDisplay = eternal.CreateEternal();
                                goalsList.Add(eternalString);
                                goalsDisplayList.Add(eternalDisplay);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[success]");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(" eternal goal created!");
                                Console.ResetColor();
                            }
                            catch{
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[error]");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" invalid input! Goal was not created!");
                                Console.ResetColor();
                            }
                            Console.ReadKey();
                            break;
                        case "3": // checklist goal
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Goal name: ");
                            Console.ResetColor();
                            goalName = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Goal description: ");
                            Console.ResetColor();
                            description = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Amount of points associated with the goal: ");
                            Console.ResetColor();
                            try{
                                points = Int32.Parse(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Number of times the goal needs to be accomplished for a bonus: ");
                                Console.ResetColor();
                                toComplete = Int32.Parse(Console.ReadLine());
                                Checklist checklist = new Checklist(goalName, description, points, toComplete, 0);
                                string checklistString = checklist.GetStringRepresentation();
                                string checklistDisplay = checklist.CreateChecklist();
                                goalsList.Add(checklistString);
                                goalsDisplayList.Add(checklistDisplay);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[success]");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(" checklist goal created!");
                                Console.ResetColor();
                            }
                            catch{
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[error]"); 
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" invalid input! Goal was not created!");
                                Console.ResetColor();
                            }
                            Console.ReadKey();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[error]"); 
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" invalid input!");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                    }
                    break;
                case "2": // display
                    DisplayGoals(goalsDisplayList);
                    Console.ReadKey();
                    break;
                case "3": // save
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter filename: ");
                    Console.ResetColor();
                    filename = Console.ReadLine();
                    if (goalsList.Count > 0){
                        try{
                            WriteToFile(goalsList, filename);
                            goalsList.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[success]"); 
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(" saved!");
                            Console.ResetColor();
                        }
                        catch{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write("[error]"); 
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" not saved!");
                            Console.ResetColor();
                        }
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[note] ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("nothing to save..");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    break;
                case "4": // load
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter filename: ");
                    Console.ResetColor();
                    filename = Console.ReadLine();
                    try{
                        goalsDisplayList = LoadFromFile(filename);
                        goalInfo = LoadFromFile(filename);
                        goalsDisplayList = Beautify(goalsDisplayList);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[sucess]");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" file loaded");
                        Console.ResetColor();
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[error]"); 
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(" file not found!");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    break;
                case "5": // record
                    if (DisplayGoalNames(goalInfo)){
                        try{
                            goalsDisplayList = LoadFromFile(filename);
                            goalInfo = LoadFromFile(filename);
                            goalsDisplayList = Beautify(goalsDisplayList);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Which goal did you accomplish?: ");
                            Console.ResetColor();
                            int accomplished = Int32.Parse(Console.ReadLine());
                            int pointsToUpdate = getSpecificPoints(accomplished,goalInfo);
                            totalPoints += pointsToUpdate;
                            updatePoints(pointsFile,totalPoints);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"Congratulations! You have earned ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(pointsToUpdate); 
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" points!");
                            Console.Write($"You now have ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(totalPoints); 
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" points");
                            updateGoalStatus(filename, accomplished);
                            goalsDisplayList = LoadFromFile(filename);
                            goalInfo = LoadFromFile(filename);
                            goalsDisplayList = Beautify(goalsDisplayList);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("[update]");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" goal status updated!");
                            Console.ResetColor();
                        }
                        catch{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[error]");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" can't be accomplished..");
                            Console.ResetColor();
                        }
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[warning]");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(" consider loading first.");
                    }
                    Console.ReadKey();
                    break;
                case "6": // delete
                    if (DisplayGoalNames(goalInfo)){
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Which goal do you want to delete?: ");
                        Console.ResetColor();
                        int toDelete = Int32.Parse(Console.ReadLine());
                        if(deleteGoal(toDelete, filename)){
                            goalsDisplayList = LoadFromFile(filename);
                            goalInfo = LoadFromFile(filename);
                            goalsDisplayList = Beautify(goalsDisplayList);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[success]");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(" goal has been removed.");
                            Console.ResetColor();
                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[error]");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" can't be deleted...");
                            Console.ResetColor();
                        }
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[warning]");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(" consider loading first.");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    break;
                case "7": // quit
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[error]");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" invalid menu entry!");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
            }
            
        }
    
    }

    static void PrintMenu(){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Delete Goals
    7. Quit");
    Console.ResetColor();
    }
    static void PrintGoalTypes(){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal");
    Console.ResetColor();
    }
    static void WriteToFile(List<string> goals, string filename){
        using (StreamWriter sw = File.AppendText(filename))
        {
            foreach(string s in goals){
                sw.WriteLine(s);
            }
        }
    }
    static void DisplayGoals(List<string> goals){
        int gc = 1;
        if (goals.Count > 0){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The goals are:");
            foreach(string goal in goals){
                Console.WriteLine($"{gc}. {goal}");
                gc++;
            }
            Console.ResetColor();
        }
        else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[note]");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" nothing to display...");
            Console.ResetColor();
        }
    }
    static List<string> LoadFromFile(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> loaded = new List<string>();
        foreach(string line in lines){
            loaded.Add(line);
        }
        return loaded;
    }
    static List<string> Beautify(List<string> list){
        List<string> temp = new List<string>();
        string r;
        foreach(string line in list){
            string[] sline = line.Split("|");
            if (sline.Length == 4){
                if (sline[3].Contains("False")){
                    r = $"[ ] {sline[0].Trim()} ({sline[1].Trim()})";
                }
                else{
                    r = $"[x] {sline[0].Trim()} ({sline[1].Trim()})";
                }    
            } 
            else if (sline.Length == 3){
                r = $"[ ] {sline[0].Trim()} ({sline[1].Trim()})";
            }
            else {
                if (! isChecklistComplete(Int32.Parse(sline[4]), Int32.Parse(sline[3]))){
                    r = $"[ ] {sline[0].Trim()} ({sline[1].Trim()}) -- Currently completed: {sline[4].Trim()}/{sline[3].Trim()}";
                }
                else{
                    r = $"[x] {sline[0].Trim()} ({sline[1].Trim()}) -- Currently completed: {sline[4].Trim()}/{sline[3].Trim()}";
                    // GiveBonus(totalPoints);
                }
            }
            temp.Add(r);
        }
        return temp;
    }
    public static bool isChecklistComplete(int Comp, int toComp){
        return Comp >= toComp;
    }
    public static bool DisplayGoalNames(List<string> goals){
        int gc = 1;
        if (goals.Count > 0){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The goals are:");
            foreach(string line in goals){
                string [] goal = line.Split("|");
                Console.WriteLine($"{gc}. {goal[0]}");
                gc++;
            }
            Console.ResetColor();
            return true;
        }
        else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[note]");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" nothing to display...");
            Console.ResetColor();
            return false;
        }

    }
    public static void updatePoints(string filePath, int points)
    {
        using (StreamWriter sw = new StreamWriter(filePath, false)){
                    sw.WriteLine(points.ToString());
                }
    }
    public static int getSpecificPoints(int line, List<string> goals){
            string lineNeeded = goals[line-1];
            string [] parts = lineNeeded.Split("|");
            int points = Int32.Parse(parts[2].Trim());
            return points;
    }
    public static int getTotalPoints(string filename)
    {
        if (File.Exists(filename)){
            string line = File.ReadLines(filename).First();
            return Int32.Parse(line);
        }
        else return 0;
    }
    public static void updateGoalStatus(string filename, int line){
        {
            string[] lines = File.ReadAllLines(filename);
            string newText="";
            string lineNeeded = lines[line-1];
            string [] parts = lineNeeded.Split("|");
            // simple 
            if (parts.Length == 4){
                newText = lineNeeded.Replace("False", "True");
            }
            // checklist
            if (parts.Length == 5){
                int oldValue = Int32.Parse(parts[4]);
                int newValue = oldValue + 1;
                newText = $"{parts[0].Trim()} | {parts[1].Trim()} | {parts[2].Trim()} | {parts[3].Trim()} | {newValue}";
            } 
            
            lines[line - 1] = newText;
            File.WriteAllLines(filename, lines);
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
// TODO: bonus!!!!