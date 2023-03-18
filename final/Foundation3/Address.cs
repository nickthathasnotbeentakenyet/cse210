class Address{

    // fields
    private string _address;

    // get&set
    public string address{get=>_address;set=>_address=value;}

    // constructor
    public Address(string address){
        _address = address;
    }
    
    // method
    public string GetAddress(){
        return _address;
    }

}