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
        "If I had one thing I could do over today, what would it be?",
        "If I had to discribe the day with one word, what would it be?"
        };
        journal._fileName = @"C:\Users\warning\Documents\BYUI\CSE 210 - Programming with Classes\Journal.txt";
        int menuNumber = -1;
        object record;
        string journalPrompt = "";

        // main loop
        while(menuNumber != 5){ 
            // Displaying initial menu and taking user input
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please select one of the following choice: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("What would you like to do? ");
            Console.ResetColor();
            try{
                menuNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number");
                Console.ResetColor();
                menuNumber = -1;
            }
            switch (menuNumber)
            {
                case 1: // Write
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    journalPrompt = prompt.PromptGenerator();  
                    Console.WriteLine(journalPrompt);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(":> ");
                    entry._entryText = Console.ReadLine();
                    Console.ResetColor();
                    break;
                case 2: // Display
                    journal.Display();
                    break;
                case 3: // Load
                    break;
                case 4: // Save
                    if(entry._entryText != null){
                        record = entry.CreateEntry(journalPrompt);
                        journal.Save(record.ToString());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Successfuly saved.");
                        Console.ResetColor();
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You didn't write anything yet..");
                        Console.ResetColor();
                    }
                    break;
                case 5: // Quit
                    Console.WriteLine($"\n"+"Goodbye.");
                    break;
                default:
                    if (menuNumber != -1){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Unknown command {menuNumber}");
                        Console.ResetColor();
                    }
                    break;
            }
        }

    }
}
// # PERF: case 1,2,4,5 работают! 
// # FIXME: Load the journal from a file - Prompt the user for a filename and 
// then save the current journal (the complete list of entries) to that file location.

// Save the journal to a file - Prompt the user for a filename and 
// then load the journal (a complete list of entries) 
// from that file. This should replace any entries currently stored in memory.
// # WARNING: Пересмотреть видео! Все не правильно, но легко исправимо!