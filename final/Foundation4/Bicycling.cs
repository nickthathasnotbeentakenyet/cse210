class Bicycling: Activity{
    private float _speed;
    public float speed{get=>_speed;set=>_speed=value;}
    public Bicycling(DateTime date, int duration, float speed) 
    : base(date, duration){
        _speed = speed;
    } 
    
    public override float GetDistance(){
        return _speed * duration / 60;
    }
    public override float GetSpeed(){
        return _speed;
    } 
}