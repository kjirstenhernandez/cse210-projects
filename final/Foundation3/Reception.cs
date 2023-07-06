public class Reception : Event {
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address){
        _eventType = "Reception";
        _email = email;
    }

    public override void DisplayDetailedMessage(){
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {base.GetTitle()}");
        Console.WriteLine($"Description: {base.GetDescription()}");
        Console.WriteLine($"Date and Time: {base.GetDate()}, {base.GetTime()}");
        Console.WriteLine($"Please send RSVP to: {_email}");
    }
}