public class Hider{

    // properties
    private List<string> _oldScripture = new List<string>();
    private List<string> _hiddenList = new List<string>();
    // getters & setters
    public List<string> OldScripture { get => _oldScripture; set => _oldScripture = value; }
    public List<string> HiddenList { get => _hiddenList; set => _hiddenList = value; }
    // methods
    public List<string> getHiddenScript(){
        foreach(string word in _hiddenList)
        if (_oldScripture.Contains(word)){
            int index = _oldScripture.IndexOf(word);
            int letters = word.Count();
            string underscore = new string('_',letters);
            _oldScripture[index] = underscore;
        }
        return _oldScripture;
    }
}
