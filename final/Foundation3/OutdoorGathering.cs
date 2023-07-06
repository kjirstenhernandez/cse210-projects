public class OutdoorGathering : Event{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address){
        _eventType = "OutdoorGathering";
        _weather = weather;
    }

    public override void DisplayDetailedMessage(){
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {base.GetTitle()}");
        Console.WriteLine($"Description: {base.GetDescription()}");
        Console.WriteLine($"Date and Time: {base.GetDate()}, {base.GetTime()}");
        Console.WriteLine($"Weather Notice: {this.GetWeatherNotice()}");
    }

    public string GetWeatherNotice(){
        switch (_weather){
            case "Sunny":
                default:
                return "The weather will be Sunny.  Be prepared by wearing sunscreen and bringing any preferred methods of sun protection, i.e. sunglasses or wide-brimmed hats";
            case "Rainy":
                return "The weather will by Rainy.  Be prepared with an umbrella or rainjacket.";
            case "Snowy":
                return "The weather will by Snowy.  Be prepared by dressing in suitable winter attire and an umbrella.";
            case "Cloudy":
                return "The weather will be Cloudy.  Sunglasses are still recommended in overcast conditions.";
        }
    }
}