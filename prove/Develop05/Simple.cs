class Simple : Goal {
    private bool _isComplete;

    public Simple(string Name, string Description, int Points, bool isComplete): base (Name, Description, Points){
        _isComplete = isComplete;
    }

    public string GetStringRepresentation(){
        return (GoalName + " | " + GoalDescription + " | " + Points.ToString() + " | " + _isComplete.ToString());
    }
    public string CreateSimple(){
        return $"[ ] {GoalName} ({GoalDescription})";
    }
}