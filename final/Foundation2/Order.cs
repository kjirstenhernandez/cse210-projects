public class Order {
    private Customer _customer;
    private double _total;
    List<Product> products = new List<Product>();

    public Order(Customer customer){
        _customer = customer;
    }

    public void AddToOrder(Product product){
        products.Add(product);
    }

    public double GetTotal(){
        foreach (Product product in products){
            _total = _total + product.GetPrice();
        }
        if (_customer.IsCustomerInUS() == false){
            _total += 35;
        }
        else if (_customer.IsCustomerInUS() == true){
            _total += 5;
        }
        
        return _total;
    }

    public void DisplayPackingLabel(){
        foreach (Product item in products){
            Console.WriteLine($"Item: #{item.GetProductID()}  {item.GetName()}, Quantity: {item.GetQuantity()}");
        }
    }

    public void DisplayShippingLabel(){
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }
}