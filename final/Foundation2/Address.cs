class Address{
    // members
    private string _street, _city, _state, _country;

    // getters & setters
    public string street{get=>_street;set=>_street=value;}
    public string city{get=>_city;set=>_city=value;}
    public string state{get=>_state;set=>_state=value;}
    public string country{get=>_country;set=>_country=value;}
    
    // constructors
    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    // methods
    public bool isUSA(){
        if (country.Trim().ToUpper() == "USA") return true;
        else return false;
    }
    public string getAddress(){
        return $"\n\t{street}\n\t{city}\n\t{state}\n\t{country}";
    }
}