class Address{
    private string _address;
    public string address{get=>_address;set=>_address=value;}

    public Address(string address){
        _address = address;
    }

    public string getAddress(){
        return _address;
    }

}