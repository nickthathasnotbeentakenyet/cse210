abstract class Goal{
    private string _goalType;
    private bool _isComplete;
    private string _name;
    private string _description;
    private int _points;



    public string goalType {get => _goalType; set => _goalType = value;}
    public string name {get => _name; set => _name = value;}
    public string description {get => _description; set => _description = value;}
    public int points {get => _points; set => _points = value;}
    public bool isComplete {get => _isComplete; set => _isComplete = value;}
    
    public Goal(string goalType, bool isComplete, string name, string description, int points){
        _goalType = goalType;
        _isComplete = isComplete;
        _name = name;
        _description = description;
        _points = points;

    }
    public abstract string CreateGoal();
    
}