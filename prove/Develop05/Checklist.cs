public class Checklist : Goal {
    private bool _completed;
    private int _pointAmount;
    private int _bonusPoints;
    private int _repeatTimes;
    private int _currentTime;

    public Checklist (string name, string description, int pointAmt, int bonusPoints, int repeatTimes): base (name, description){
        _goalType = "Checklist";
        _pointAmount = pointAmt;
        _completed = false;
        _bonusPoints = bonusPoints;
        _repeatTimes = repeatTimes;
    }
    public Checklist (string name, string description, int pointAmt, int bonusPoints, int repeatTimes, int currentRepeat): base (name, description){
        _goalType = "Checklist";
        _pointAmount = pointAmt;
        _completed = false;
        _bonusPoints = bonusPoints;
        _repeatTimes = repeatTimes;
        _currentTime = currentRepeat;
    }

    public override string IsComplete(){
        if (_currentTime < _repeatTimes){
            _completed = false;
        }
        else if (_currentTime >= _repeatTimes){
            _completed = true;
        }

        return _completed ? "[X]" : "[ ]";   

    }

    public override int RecordEvent(){
        _currentTime ++;
        if (_currentTime == _repeatTimes){
            _pointAmount += _bonusPoints;
        }

        Console.WriteLine($"Congratulations! You've earned {_pointAmount} points!");
        return _pointAmount;
    }

    public override string DisplayGoal(){
        return $"{IsComplete()} {_name} ({_description}) -- Currently completed: {_currentTime}/{_repeatTimes}";

    }
    public override string SaveGoaltoFile()
    {
        return $"{_goalType},{_name},{_description},{_pointAmount},{_bonusPoints},{_repeatTimes},{_currentTime}";
    }


}