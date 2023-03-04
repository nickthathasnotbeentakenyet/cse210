class Eternal : Goal {
    public Eternal(string Name, string Description, int Points): base (Name, Description, Points){}

    public string GetStringRepresentation(){
        return (GoalName + " | " + GoalDescription + " | " + Points.ToString());
    }
    public string CreateEternal(){
        return $"[ ] {GoalName} ({GoalDescription})";
    }
}