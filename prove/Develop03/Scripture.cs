public class Scripture{
    public string _scriptText;
    public string _scriptRef;

    public List<string> scriptureToList(){
        return new List<string>(_scriptText.Split(' '));
    }
    public void DisplayScript(List<string> scripture){
        Console.Write(_scriptRef + " ");
        foreach(var o in scripture){
            Console.Write(o + " ");
        }
        Console.WriteLine();
        if(!String.Join(" ", scripture.ToArray()).Any(Char.IsLetter)){
            System.Console.Write("Press any key to exit.");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
    }
}