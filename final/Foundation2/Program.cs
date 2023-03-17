using System;
       
class Program
{
    static void Main(string[] args)
    { 
    List<Product> productsList = new List<Product>();
    float totalCost;
    string shipL;

    Product product_1 = new Product("Apples",1001, (float)12.50, 10);
    Product product_2 = new Product("Bananas",1002, (float)14.50, 5);
    productsList.Add(product_1);
    productsList.Add(product_2);
    Address address = new Address("742 Evergreen Terrace", "Springfield", "Unknown", "USA");
    Customer customer_1 = new Customer("Liza Simpson", address);
    Order order_1 = new Order(productsList, customer_1.name);
    totalCost = order_1.getTotalCost(address, productsList);
    
    System.Console.WriteLine("Products:");
    foreach(Product product in productsList){
        System.Console.WriteLine("\t" + order_1.getPackingLabel(product));
    }

    shipL = order_1.getShippingLabel(customer_1);
    System.Console.WriteLine($"Total cost:\n\t${totalCost:F2}");
    System.Console.WriteLine(shipL);


    System.Console.WriteLine("--------------------------------------");


    Product product_3 = new Product("Beer", 1003, (float) 20.99, 6);
    Product product_4 = new Product("Beef", 1004, (float) 30.99, 2);
    Product product_5 = new Product("Chips", 1005, (float) 4.99, 1);
    productsList.Clear();
    productsList.Add(product_3);
    productsList.Add(product_4);
    productsList.Add(product_5);
    Address address2 = new Address("Nuclear Station", "Springfield", "Unknown", "USA");
    Customer customer_2 = new Customer("Homer Simpson", address2);
    Order order_2 = new Order(productsList, customer_2.name);
    totalCost = order_2.getTotalCost(address2, productsList);
    
    System.Console.WriteLine("Products:");
    foreach(Product product in productsList){
        System.Console.WriteLine("\t" + order_2.getPackingLabel(product));
    }

    shipL = order_2.getShippingLabel(customer_2);
    System.Console.WriteLine($"Total cost:\n\t${totalCost:F2}");
    System.Console.WriteLine(shipL);

    
    }
}