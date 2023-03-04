abstract class Goal{
    private string _goalName;
    private string _goalDescription;
    private int _points;

    public string GoalName {get => _goalName; set => _goalName = value;}
    public string GoalDescription {get => _goalDescription; set => _goalDescription = value;}
    public int Points {get => _points; set => _points = value;}
    
    public Goal(string Name, string Description, int points){
        _goalName = Name;
        _goalDescription = Description;
        _points = points;
    }
    
}