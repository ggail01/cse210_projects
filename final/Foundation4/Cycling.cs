using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) 
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Cycling ({_length} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}