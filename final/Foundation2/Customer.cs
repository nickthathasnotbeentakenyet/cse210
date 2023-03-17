class Customer{
    // members
    private string _name;
    private Address _address;
    
    // getters & setters
    public string name{get=>_name;set=>_name=value;}
    public Address address{get=>_address;set=>_address=value;}
    
    // constructors
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    // methods
    public bool IsInUSA(Address address){
        return address.IsUSA()? true:false;
    }

}