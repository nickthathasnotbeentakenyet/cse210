class Order{

    // members
    private List<Product> _productsList = new List<Product>();
    private string _customer;

    // getters & setters
    public List<Product> productsList{get=>_productsList;set=>_productsList=value;}
    public string customer{get=>_customer;set=>_customer=value;}

    // constructors
    public Order(List<Product> productsList, string customer){
        _productsList = productsList;
        _customer = customer;
    }
    
    // methods
    public float GetTotalCost(Address address, List<Product> products){
        int inUSA = 5;
        int outUSA = 35;
        float totalPrice = 0;
        foreach (Product product in productsList){
            totalPrice += product.GetTotalPrice();
        }
        if (address.IsUSA())totalPrice += inUSA;
        else totalPrice += outUSA;
        return totalPrice;
    }
    public string GetPackingLabel(Product product){
        return $"{product.name} | {product.productId}";
    }
    public string GetShippingLabel(Customer customer){
        return $"Customer: \n\t{customer.name}\nAddress:{customer.address.GetAddress()}";
    }

}