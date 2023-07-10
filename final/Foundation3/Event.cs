public abstract class Event{
    private string _eventTitle;
    protected string _eventType;
    private string _description;
    private string _date;
    private string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address){
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetDate(string date){

    }

    public void DisplayStandardMessage(){
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");

    }

    public abstract void DisplayDetailedMessage();

    public void DisplayShortMessage(){
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_date}");
    }

    public string GetTitle(){
        return _eventTitle;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetDate(){
        return _date;
    }
    public string GetTime(){
        return _time;
    }

}