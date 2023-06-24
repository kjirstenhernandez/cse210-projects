public class Eternal : Goal {
    
    private bool _completed;
    private int _pointAmount;

    public Eternal (string name, string description, int pointAmt): base (name, description){
        _goalType = "Eternal";
        _pointAmount = pointAmt;
        _completed = false;
    }
    public override string IsComplete(){
        _completed = false;
        return "[ ]";   
    }

    public override int RecordEvent(){
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {_pointAmount} points!");
        return _pointAmount;
    }

    public override string DisplayGoal(){
        return $"{IsComplete()} {_name} ({_description})";
    }
    
    public override string SaveGoaltoFile()
    {
        return $"{_goalType},{_name},{_description},{_pointAmount}";
    }

}