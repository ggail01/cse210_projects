using System;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}