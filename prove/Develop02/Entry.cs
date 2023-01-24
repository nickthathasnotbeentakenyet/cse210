public class Entry {
    public string _entryText;
    public object _entryDateTime = DateTime.Now;

    public Entry(){
    }

    public object CreateEntry(string prompt){
        return (_entryDateTime,prompt,_entryText);
    }
    public void Display(){
        Console.WriteLine($"\n[{_entryDateTime}]");
        Console.WriteLine($"{_entryText}");
    }

}