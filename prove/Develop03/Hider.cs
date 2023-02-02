public class Hider{
    public List<string> _oldScripture = new List<string>();
    public string _wordToHide;
    public List<string> getHiddenScript(List<string> list){
        foreach(string word in list)
        if (_oldScripture.Contains(word)){
            int index = _oldScripture.IndexOf(word);
            int counter = word.Count();
            string underscore = new string('_',counter);
            _wordToHide = underscore;
            _oldScripture[index] = _wordToHide;
        }
        return _oldScripture;
    }
}
