using System;
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Randomizer randomizer = new Randomizer();
        Hider hider = new Hider();

        scripture._scriptRef = "D&C 4:6";
        scripture._scriptText = "Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence.";
        // scripture._scriptRef = "Proverbs 3:5-6";
        // scripture._scriptText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Console.Clear();
        scripture.DisplayScript(scripture.scriptureToList());
        System.Console.Write("Press enter to continue or type 'quit' to finish: ");
        string quit = Console.ReadLine();
        while (quit != "quit" )
        {
            Console.Clear();
            string randomWord = randomizer.getRandomWord(scripture.scriptureToList());
            hider._oldScripture = scripture.scriptureToList();
            List<string> hiddenList = randomizer._hiddenList;
            scripture.DisplayScript(hider.getHiddenScript(hiddenList));
            foreach(var i in randomizer._indexList){System.Console.Write(i + ", ");};
            System.Console.WriteLine();
            System.Console.Write("Press enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();
        }
    }
}