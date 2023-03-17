class Bicycling: Activity{
    private float _speed;
    public float speed{get=>_speed;set=>_speed=value;}
    public Bicycling(DateTime date, int duration, float speed) 
    : base(date, duration){
        _speed = speed;
    } 
    
    public override float getDistance(){
        // км/ч * ч
        return _speed * duration / 60;
    }
    public override float getSpeed(){
        return _speed;
    } 
    public override float getPace(){
        return duration / getDistance();
    } 
    public override string getSummary(){
        return $"[{date.ToString("dd MMMM yyyy")} ({duration} min)] Distance: {getDistance():F1} km, Speed: {getSpeed()} kph, Pace: {getPace()} min per km";
    }
}