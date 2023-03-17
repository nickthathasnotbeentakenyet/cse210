class Running : Activity{
    private float _distance;
    public float distance{get=>_distance;set=>_distance=value;}
    public Running(DateTime date, int duration, float distance) 
    : base(date, duration){
        _distance = distance;
    } 
    
    public override float getDistance(){
        return _distance;
    }
    public override float getSpeed(){
        return (getDistance() / duration) * 60;
    } 
    public override float getPace(){
        return duration / getDistance();
    } 
    public override string getSummary(){
        return $"[{date.ToString("dd MMMM yyyy")} ({duration} min)] Distance: {getDistance():F1} km, Speed: {getSpeed()} kph, Pace: {getPace()} min per km";
    }
}