public class Product{
    private string _name;
    private int _productID;
    private double _indPrice;
    private int _quantity;

    public Product(string productName, int quantity){
        _name = productName;
        _quantity = quantity;
        SetProductInfo();
    }

    public double GetPrice(){
        return _indPrice * _quantity;
    }

    public void SetProductInfo(){
        if (_name == "Cabbage"){
            _indPrice = 0.40;
            _productID = 61703;
        }
        else if (_name == "Bananas"){
            _indPrice = 0.29;
            _productID = 93626;
        }
        else if (_name == "Peanut Butter"){
            _indPrice = 3.00;
            _productID = 40335;
        }
        else if (_name == "Apples"){
            _indPrice = 0.25;
            _productID = 61999;
        }
        else if (_name == "Milk"){
            _indPrice = 2.00;
            _productID = 74187;
        }
        else if (_name == "Cheese"){
            _indPrice = 1.50;
            _productID = 72816;
        }
        else if (_name == "Bread"){
            _indPrice = 2.00;
            _productID = 53082;
        }
        else if (_name == "Sugar"){
            _indPrice = 1.50;
            _productID = 90023;
        }
        else if (_name == "Juice"){
            _indPrice = 1.50;
            _productID = 46110;
        }
        else if (_name == "Soda"){
            _indPrice = 1.00;
            _productID = 33856;
        }
        else if (_name == "Detergent"){
            _indPrice = 4.29;
            _productID = 39562;
        }
    }
    
    public string GetName(){
        return _name;
    }

    public int GetProductID(){
        return _productID;
    }

    public int GetQuantity(){
        return _quantity;
    }
}