public class Randomizer{

    public List<string> _hiddenList = new List<string>();
    public string _hidden;
    public int _index;
    public List<int> _indexList = new List<int>();
    public string getRandomWord(List<string> oldScript){
        
        while (true){
            Random random = new Random();
            _index = random.Next(oldScript.Count);
            _hidden = oldScript[_index];
            if (!_hidden.ToString().Contains("_") && !_indexList.Contains(_index)){break;}
        }
        if (!_indexList.Contains(_index)){
            _hiddenList.Add(_hidden);
            _indexList.Add(_index);
        }
        return  _hidden;
    }
}
