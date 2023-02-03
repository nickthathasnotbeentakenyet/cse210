public class Scripture{
    
    // properties 
    private string _scriptText;
    private string _scriptRef;
    private List<string> _scriptureList = new List<string>();

    // constructors
    public Scripture(){}
    public Scripture(string Ref, string Text){
        _scriptRef = Ref;
        _scriptText = Text;
    }
    public Scripture(string Text){
        _scriptRef = "Unknown Reference";
        _scriptText = Text;
    }
    // getters & setters
    public string ScriptText { get => _scriptText; set => _scriptText = value; }
    public string ScriptRef { get => _scriptRef; set => _scriptRef = value; }
    public List<string> ScriptureList { get => _scriptureList; set => _scriptureList = value; }
    // methods
    public List<string> scriptureToList(){
        return new List<string>(_scriptText.Split(' '));
    }
    public void DisplayScript(){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(_scriptRef + " ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\"");
        foreach(var o in _scriptureList){
            Console.Write(o + " ");
        }
        Console.WriteLine("\"");
        Console.ResetColor();
        if(!String.Join(" ", _scriptureList.ToArray()).Any(Char.IsLetter)){
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write("Press any key to exit.");
            Console.ResetColor();
            Console.ReadLine();
            System.Environment.Exit(0);
        }
    }
}