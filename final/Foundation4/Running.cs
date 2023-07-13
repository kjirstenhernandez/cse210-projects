public class Running : Activity {
    
    private double _distance;

    public Running(int length, double distance) : base(length){
        _distance = distance;
        _activityType = "Running";
    }
    public override double GetDistance(){
        return _distance;

    }
    public override double GetSpeed(){
        double distance = Convert.ToDouble(_distance);
        return distance / base.GetLength() * 60;

    }
    public override double GetPace(){
        Console.WriteLine(60 / GetSpeed());
        return base.GetLength() / _distance;
    }

}