using System;
public class OutdoorGathering : Event
{
private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GenerateDetailedOutdoorGathering()
    {
        string detailed = GenerateStandard() + "\n";
        detailed += $"The weather will be {_weather}.";
        return detailed;
    }
    public string GenerateShortOutdoorGathering()
    {
        string shortReception = "Event Type: OutdoorGathering" + "\n";
        shortReception += GenerateShort();
        return shortReception;
    }
}