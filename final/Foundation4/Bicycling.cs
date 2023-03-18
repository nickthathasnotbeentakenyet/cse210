class Bicycling: Activity{

    // fields
    private float _speed;

    // get&set
    public float speed{get=>_speed;set=>_speed=value;}

    // constructor
    public Bicycling(DateTime date, int duration, float speed) 
    : base(date, duration){
        _speed = speed;
    } 
    
    // methods
    protected override float GetDistance(){
        return _speed * duration / 60;
    }
    protected override float GetSpeed(){
        return _speed;
    } 
}