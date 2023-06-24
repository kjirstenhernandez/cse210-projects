public abstract class Goal {
    protected string _name;
    protected string _description;
    protected string _goalType;

    public Goal(string name, string description){
        _name = name;
        _description = description;
    }

    public abstract string IsComplete();

    public abstract int RecordEvent();

    public abstract string DisplayGoal();

    public abstract string SaveGoaltoFile();

    public string GetName(){
        return _name;
    }
}
