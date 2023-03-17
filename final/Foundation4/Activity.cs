abstract class Activity{
    private DateTime _date = new DateTime();
    private int _duration;
    public DateTime date{get=> _date;set=>_date=value;}
    public int duration{get=>_duration;set=>_duration=value;}
    public Activity(DateTime date, int duration){
        _date = date;
        _duration = duration;
    } 
    public abstract float getDistance();
    public abstract float getSpeed(); 
    public abstract float getPace(); 
    public abstract string getSummary();

}