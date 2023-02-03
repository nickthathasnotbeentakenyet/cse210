public class Randomizer{

    // properties
    private string _hidden;
    private int _index;
    private List<int> _indexList = new List<int>();
    private List<string> _hiddenList = new List<string>();
    private List<string> _Scripture = new List<string>();
    
    // getters & setters
    public List<string> HiddenList { get => _hiddenList; set => _hiddenList = value; }
    public List<string> Scripture { get => _Scripture; set => _Scripture = value; }

    // methods
    public string getRandomWord(){
        
        while (true){
            Random random = new Random();
            _index = random.Next(_Scripture.Count);
            _hidden = _Scripture[_index];
            if (!_hidden.ToString().Contains("_") && !_indexList.Contains(_index)){break;}
        }
        if (!_indexList.Contains(_index)){
            _hiddenList.Add(_hidden);
            _indexList.Add(_index);
        }
        return  _hidden;
    }
}
