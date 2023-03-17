class Outdoor : Event{
    private string _weather;
    public string Weather{get=>_weather;set=>_weather=value;}
    public Outdoor(string title, string description, string date, string time, Address address, string weather) 
    : base(title, description, date, time, address){
        _weather = weather;
    }
    public string getFullMsg(){
        return @$"
Title: {title}
Description: {description}
Date: {date}
Time: {time}
Address: {address.getAddress()}
Weather: {_weather}
";
    }
}