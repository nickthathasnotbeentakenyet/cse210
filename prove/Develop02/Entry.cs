public class Entry {
    public string _entryText;
    public string _entryDate = DateTime.Today.ToShortDateString();
    public string _entryTime = DateTime.Now.ToShortTimeString();
    
    public object CreateEntry(string prompt){
        return (_entryDate, _entryTime, prompt, _entryText).ToTuple();
    }
}