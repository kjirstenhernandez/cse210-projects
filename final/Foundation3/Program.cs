using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("261 W 200 S", "Springville", "Utah", "United States");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("TestingTitle", "This is the testing description", "Thursday, July 6th", "7:00pm", address1, "Cloudy");
        outdoorGathering1.DisplayDetailedMessage();
    }
}