class Product{
    
    // members
    private string _name; 
    private int _id;
    private float _price;
    private int _quantity;
 
    // getters & setters
    public string name{get=>_name;set=>_name=value;}
    public int productId{get=>_id;set=>_id=value;}
    public float price{get=>_price;set=>_price=value;}
    public int quantity{get=>_quantity;set=>_quantity=value;}

    // constructors
    public Product(string name, int productId, float price, int quantity){
        _name = name;
        _id = productId;
        _price = price;
        _quantity = quantity;
    }

    // methods
    public float GetTotalPrice(){
        return price * quantity;
    }
}

