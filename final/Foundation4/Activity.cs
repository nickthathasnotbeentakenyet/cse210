abstract class Activity{
    private DateTime _date = new DateTime();
    private int _duration;
    public DateTime date{get=> _date;set=>_date=value;}
    public int duration{get=>_duration;set=>_duration=value;}
    public Activity(DateTime date, int duration){
        _date = date;
        _duration = duration;
    } 
    public abstract float GetDistance();
    public abstract float GetSpeed(); 
    public float GetPace(){
        return duration / GetDistance();
    }  
    public string GetSummary(){
        return $"[{date.ToString("dd MMMM yyyy")} ({duration} min)] Distance: {GetDistance():F1} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

}