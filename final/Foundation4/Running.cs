class Running : Activity{
    private float _distance;
    public float distance{get=>_distance;set=>_distance=value;}
    public Running(DateTime date, int duration, float distance) 
    : base(date, duration){
        _distance = distance;
    } 
    
    public override float GetDistance(){
        return _distance;
    }
    public override float GetSpeed(){
        return (GetDistance() / duration) * 60;
    } 
}