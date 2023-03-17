class Swimming : Activity{
    private int _laps;
    public int laps{get=>_laps;set=>_laps=value;}
    public Swimming(DateTime date, int duration, int laps) 
    : base(date, duration){
        _laps = laps;
    } 
    
    public override float GetDistance(){
        return _laps * 50 / 1000;
    }
    public override float GetSpeed(){
        return (GetDistance() / duration) * 60;
    } 
}