using System.Collections;
public class Journal
{
    public string _fileName;

    public ArrayList _allEntries = new ArrayList();

    public void Display(ArrayList journal)
    {
        foreach (var o in journal)
        {
            string record = o.ToString();
            string cleanRecord = record.Replace("(", "").Replace(")", "");
            string[] recordParts = cleanRecord.Split(new[] { ',' }, 4);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nDate: {recordParts[0]} \nTime:{recordParts[1]} \nPrompt:{recordParts[2]}");
            Console.WriteLine($"Record: {recordParts[3].TrimStart()}");
            Console.ResetColor();
        }
    }

    public void Save(ArrayList journal, string filePath)
    {
        using (StreamWriter sw = new StreamWriter(filePath, false))
        {
            foreach (var o in journal)
            {
                string record = o.ToString();
                {
                    sw.WriteLine(o);
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success: file saved.");
        Console.ResetColor();
    }

    public ArrayList Load(string filePath)
    {
        string[] journal = File.ReadAllLines(filePath);
        ArrayList list = new ArrayList(journal);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success: file loaded.");
        Console.ResetColor();
        return list;
    }
}