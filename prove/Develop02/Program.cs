using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        // instances
        Prompt prompt = new Prompt();
        Entry entry = new Entry();
        Journal journal = new Journal();

        // variables
        prompt._promptList = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today. What would it be?",
        "If I had to discribe the day with one word. What would it be?"
        };
        object createdEntry;
        ArrayList allEntries = journal._allEntries;

        int menuNumber = -1;
        // main loop
        while (menuNumber != 5)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPlease select one of the following choice: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Console.ResetColor();
            try{
                menuNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: invalid input. Please enter a number");
                Console.ResetColor();
                menuNumber = -1;
            }

            switch (menuNumber)
            {
                case 1: // Write
                    string uPrompt = prompt.PromptGenerator();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(uPrompt);
                    Console.Write(":> ");
                    Console.ResetColor();
                    entry._entryText = Console.ReadLine();
                    createdEntry = entry.CreateEntry(uPrompt);
                    allEntries.Add(createdEntry);
                    break;
                case 2: // Display
                    if (allEntries.Count > 0){
                        journal.Display(allEntries);
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning: nothing to display yet.");
                        Console.ResetColor();
                    }
                    break;
                case 3: // Load
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Please enter the filename: ");
                    Console.ResetColor();
                    journal._fileName = Console.ReadLine();
                    try{
                        allEntries = journal.Load(journal._fileName);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: File not found.");
                        Console.ResetColor();
                    }
                    break;
                case 4: // Save
                    if(entry._entryText != null){
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Please enter the filename: ");
                        Console.ResetColor();
                        journal._fileName = Console.ReadLine();
                        journal.Save(allEntries, journal._fileName);
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning: Nothing to save. Please, write first.");
                        Console.ResetColor();
                    }
                    break;
                case 5: // Quit
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nGoodbye.");
                    Console.ResetColor();
                    break;
                default:
                    if (menuNumber != -1){
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Error: unknown menu entry {menuNumber}");
                            Console.ResetColor();
                    }
                    break;
            }
        }

    }
}