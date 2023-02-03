using System;
class Program
{
    static void Main(string[] args)
    {
        int menuNumber;
        int correctIndex = 1;
        string[,] scriptureCollection = new string[5, 2] {
            { "D&C 4:6", "Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence." },
            { "Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths." },
            { "1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may ccomplish the thing which he commandeth them." },
            { "2 Niphi 25:26", "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins." },
            { "D&C 10:5", "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work." }
        };
        Console.Clear();
        while (true)
        {
            DisplayMenu(scriptureCollection);
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Please choose scripture number to memorize: ");
            System.Console.Write(":> ");
            Console.ResetColor();
            try
            {
                menuNumber = int.Parse(Console.ReadLine());
                if (menuNumber > 0 && menuNumber <= scriptureCollection.GetLength(0))
                {
                    Randomizer randomizer = new Randomizer();
                    Hider hider = new Hider();
                    Console.Clear();
                    Scripture scripture = new Scripture(scriptureCollection[menuNumber - correctIndex, 0], scriptureCollection[menuNumber - correctIndex, 1]);
                    scripture.ScriptureList = scripture.scriptureToList();
                    scripture.DisplayScript();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Console.Write("Press enter to continue or type 'quit' to finish: ");
                    System.Console.Write(":> ");
                    Console.ResetColor();
                    string quit = Console.ReadLine();
                    while (quit != "quit")
                    {
                        Console.Clear();
                        randomizer.Scripture = scripture.scriptureToList();
                        randomizer.getRandomWord();
                        hider.OldScripture = scripture.scriptureToList();
                        hider.HiddenList = randomizer.HiddenList;
                        scripture.ScriptureList = hider.getHiddenScript();
                        scripture.DisplayScript();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.Write("Press enter to continue or type 'quit' to finish: ");
                        System.Console.Write(":> ");
                        Console.ResetColor();
                        quit = Console.ReadLine();
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {menuNumber} doesn't exist");
                    Console.ResetColor();
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: invalid input. Please enter an integer.");
                Console.ResetColor();
            }
        }
    }
    static void DisplayMenu(string[,] scriptures)
    {
        for (int i = 0; i < scriptures.GetLength(0); i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write($"{i + 1}. ");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(scriptures[i, 0]);
            Console.ResetColor();
        }
    }
}