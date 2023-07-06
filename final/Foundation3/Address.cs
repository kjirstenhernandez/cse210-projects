public class Address{
    private string _street;
    private string _line2;
    private string _city;
    private string _stateProv;
    private string _country;

    public Address(string street, string city, string stateProv, string country){
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }
    public Address(string street, string line2, string city, string stateProv, string country){
        _street = street;
        _line2 = line2;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }

    public string GetFullAddress(){
        if (_line2 == null){
            return $"{_street}, {_city}, {_stateProv}, {_country}";
        }
        else{
            return $"{_street}, {_line2}, {_city}, {_stateProv}, {_country}";
        }
    }
}