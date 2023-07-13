public class Cycling : Activity {
    private double _speed;

    public Cycling(int length, double speed) : base(length){
        _speed = speed;
        _activityType = "Cycling";
    }
    public override double GetDistance(){
        return _speed / 60 * base.GetLength();
    }
    public override double GetSpeed(){
        return _speed;
    }
    public override double GetPace(){
        return 60 / GetSpeed();
    }

}