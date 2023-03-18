class Swimming : Activity{

    // fields
    private int _laps;

    // get&set
    public int laps{get=>_laps;set=>_laps=value;}

    // constructor
    public Swimming(DateTime date, int duration, int laps) 
    : base(date, duration){
        _laps = laps;
    } 
    
    // methods
    protected override float GetDistance(){
        return _laps * 50 / 1000;
    }
    protected override float GetSpeed(){
        return (GetDistance() / duration) * 60;
    } 
}