public class Address{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;
    private string _line2;
    private bool _ifLine2;
    private bool _inUS;

    public Address(){
        
    }
    public Address(string street, string city, string stateProv, string country){
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
        _ifLine2 = false;
    }
    public Address(string street, string line2, string city, string stateProv, string country){
        _street = street;
        _line2 = line2;
        _city = city;
        _stateProv = stateProv;
        _country = country;
        _ifLine2 = true;
    }

    public bool DetermineIfUS(){
        if (_country == "USA" || _country == "United States"){
            _inUS = true;
        }
        else{
            _inUS = false;
        }
        return _inUS;
    }

    public string GetFullAddress(){
        if (_ifLine2 == true){
            return $"{_street}, {_line2}, {_city}, {_stateProv}, {_country}";
        }
        else {
            return $"{_street}, {_city}, {_stateProv}, {_country}";
        }
    }
}