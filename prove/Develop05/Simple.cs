public class Simple : Goal{
    
    private bool _completed;
    private int _pointAmount;
    
    public Simple (string name, string description, int pointAmt): base (name, description){
        _goalType = "Simple";
        _pointAmount = pointAmt;
        _completed = false;
    }
    

    public override string IsComplete(){
        return _completed ? "[X]" : "[ ]";   
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
        return $"{_goalType},{_name},{_description},{_pointAmount},{_completed}";
    }

    public void SetCompletion(bool statement){
        _completed = statement;
    }
}