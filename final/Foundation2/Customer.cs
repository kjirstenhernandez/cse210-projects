public class Customer{
    private string _name;
    private bool _inUS;

    Address address = new Address();

    public Customer(string name, string street, string city, string stateProv, string country){
        _name = name; 
        address = new Address(street, city, stateProv, country);

    }
    public Customer(string name, string street, string line2, string city, string stateProv, string country){
        _name = name; 
        address= new Address(street, line2, city, stateProv, country);
    }

    public bool IsCustomerInUS(){
        _inUS = address.DetermineIfUS();
        return _inUS;
    }

    public string GetName(){
        return _name;
    }
    
    public string GetAddress(){
        return address.GetFullAddress();
    }
}