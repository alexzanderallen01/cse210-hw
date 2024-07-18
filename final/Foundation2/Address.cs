using System;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }
    public string GenerateCompleteAddress()
    {
        string address = _street + ", " + _city + ", " + _state + ", " + _zip;
        return address;
    }
    public bool isUSA()
    {
        return _zip == "USA" ? true : false;        //Credit to my friend Garret for teaching me that I could do this.
    }
}