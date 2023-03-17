class Event{
    // fields
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    // get&set
    public string title{get=> _title ; set=> _title=value ;}
    public string description{get=> _description; set=> _description=value;}
    public string date{get=> _date; set=> _date=value;}
    public string time{get=> _time; set=> _time=value;}
    public Address address{get=> _address; set=> _address=value;}
    // constructor
    public Event(string title, string description, string date, string time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    // methods
    public string GetStandardMsg(){
        return @$"
Title: {title}
Description: {description}
Date: {date}
Time: {time}
Address: {address.GetAddress()}
";
    } 
    public string GetShortMsg(string eventType){
        return $"{eventType} \nTitle: {title}\nDate: {date}\n";
    }
}