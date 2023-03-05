class Checklist : Goal {
    private int _toComplete;
    private int _completed;
    private int _bonus;
    public Checklist(string goalType,bool isComplete, string name, string description, int points, int bonus, int completed, int toComplete )
    : base (goalType, isComplete, name, description, points){
        _bonus = bonus;
        _completed = completed;
        _toComplete = toComplete;
    }

    public override string CreateGoal(){
        return $"{goalType} | {isComplete} | {name} | {description} | {points} | {_bonus} | {_completed} | {_toComplete}";
    }

}


