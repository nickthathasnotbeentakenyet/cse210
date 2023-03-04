class Checklist : Goal {
    private int _toComplete;
    private int _completed;

    public Checklist(string Name, string Description, int Points, int toComplete, int completed): base (Name, Description, Points){
        _toComplete = toComplete;
        _completed = completed;
    }

    public string GetStringRepresentation(){
        return (GoalName + " | " + GoalDescription + " | " + Points.ToString() 
        + " | " + _toComplete.ToString() + " | " + _completed.ToString());
    }
    public string CreateChecklist(){
        return $"[ ] {GoalName} ({GoalDescription}) -- Currently completed: {_completed}/{_toComplete}";
    }

}


