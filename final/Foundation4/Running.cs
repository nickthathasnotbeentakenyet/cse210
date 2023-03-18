class Running : Activity{

    // fields
    private float _distance;

    // get&set
    public float distance{get=>_distance;set=>_distance=value;}

    // constructor
    public Running(DateTime date, int duration, float distance) 
    : base(date, duration){
        _distance = distance;
    } 
    
    // methods
    protected override float GetDistance(){
        return _distance;
    }
    protected override float GetSpeed(){
        return (GetDistance() / duration) * 60;
    } 
}