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
    public float getTotalCost(Address address, List<Product> products){
        int inUSA = 5;
        int outUSA = 35;
        float totalPrice = 0;
        foreach (Product product in productsList){
            totalPrice += product.getTotalPrice();
        }
        if (address.isUSA() == true){totalPrice += inUSA;}
        else totalPrice += outUSA;
        return totalPrice;
    }
    public string getPackingLabel(Product product){
        return $"{product.name} | {product.productId}";
    }
    public string getShippingLabel(Customer customer){
        return $"Customer: \n\t{customer.name}\nAddress:{customer.address.getAddress()}";
    }

}