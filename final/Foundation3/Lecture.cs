class Lecture : Event{
    // fields
    private string _speaker;
    private int _capacity;
    // get&set
    public string speaker{get=>_speaker;set=>_speaker=value;}
    public int capacity{get=>_capacity;set=>_capacity=value;}
    // constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) 
    : base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }
    // method
    public string GetFullMsg(){
        return @$"
Title: {title}
Description: {description}
Date: {date}
Time: {time}
Address: {address.GetAddress()}
Speaker: {_speaker}
Capacity: {_capacity}
";
    }
}