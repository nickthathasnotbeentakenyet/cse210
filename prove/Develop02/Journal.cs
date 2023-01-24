public class Journal{
    public string _fileName;
    public Journal(){
    }

    public void Display(){
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.ResetColor();
        }
        // возможно стоит передать содержимое файла как аргумент и затем прочитать его
        // таким образом метод лоад будет задействован 
    }
    public void Save(string record){
        using (StreamWriter sw = File.AppendText(_fileName))
        {
            string cleanRecord = record.Replace("(", "").Replace(")", "");
            string[] recordParts = cleanRecord.Split(new[] { ',' }, 3);
            foreach (var _ in recordParts)
            {
                sw.WriteLine(_.TrimStart());
            } 
        }	
    }

    public object Load(){
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        return lines;
    }
}