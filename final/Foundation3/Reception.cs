class Reception : Event{
    // fields
    private string _rsvpEmail;
    // get&set
    public string RSVPemail{get=>_rsvpEmail;set=>_rsvpEmail=value;}
    // constructor
    public Reception(string title, string description, string date, string time, Address address, string RSVPemail) 
    : base(title, description, date, time, address){
        _rsvpEmail = RSVPemail;
    }
    // method
    public string GetFullMsg(){
        return @$"
Title: {title}
Description: {description}
Date: {date}
Time: {time}
Address: {address.GetAddress()}
RSVP-email: {_rsvpEmail}
";
    }
}