class Reception : Event{
    private string _RSVPemail;
    public string RSVPemail{get=>_RSVPemail;set=>_RSVPemail=value;}
    public Reception(string title, string description, string date, string time, Address address, string RSVPemail) 
    : base(title, description, date, time, address){
        _RSVPemail = RSVPemail;
    }
    public string getFullMsg(){
        return @$"
Title: {title}
Description: {description}
Date: {date}
Time: {time}
Address: {address.getAddress()}
RSVP-email: {_RSVPemail}
";
    }
}