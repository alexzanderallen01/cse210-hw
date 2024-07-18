using System;
public class Event
{
    private string _titles;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _titles = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GenerateStandard()
    {
        string standard = "Title: " + _titles + "\n";
        standard += "Description: " + _description + "\n";
        standard += _date + " | " + _time + "\n";
        standard += _address.GenerateCompleteAddress();
        return standard;
    }
    public string GenerateShort()
    {
        string shortD = "Title: " + _titles + "\n";
        shortD += _date + "\n";
        return shortD;
    }
}