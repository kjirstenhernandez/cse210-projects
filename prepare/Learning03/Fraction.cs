public class Fraction {
    private int _top;
    private int _bottom; 

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholenumber){
        _top = wholenumber;
        _bottom = 1;
    }

    public Fraction (int top_number, int bottom_number){
        _top = top_number;
        _bottom = bottom_number;
    }

    public string GetFractionString(){
        return (_top + "/" + _bottom);
    }

    public double GetDecimalValue(){
        return (double) _top / (double) _bottom;
    }

}
