class Swimming : Activity{
    private int _laps;
    public int laps{get=>_laps;set=>_laps=value;}
    public Swimming(DateTime date, int duration, int laps) 
    : base(date, duration){
        _laps = laps;
    } 
    
    public override float getDistance(){
        return _laps * 50 / 1000;
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