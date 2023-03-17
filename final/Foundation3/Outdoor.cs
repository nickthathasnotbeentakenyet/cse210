class Outdoor : Event{
    // field
    private string _weather;
    // get&set
    public string weather{get=>_weather;set=>_weather=value;}
    // constructor
    public Outdoor(string title, string description, string date, string time, Address address, string weather) 
    : base(title, description, date, time, address){
        _weather = weather;
    }
    // method
    public string GetFullMsg(){
        return @$"
Title: {title}
Description: {description}
Date: {date}
Time: {time}
Address: {address.GetAddress()}
Weather: {_weather}
";
    }
}