class Eternal : Goal {
    public Eternal(string goalType, bool isComplete ,string name, string description, int points)
    : base (goalType, isComplete, name, description, points){}

    public override string CreateGoal(){
        return $"{goalType} | {isComplete} | {name} | {description} | {points}";
    }
}