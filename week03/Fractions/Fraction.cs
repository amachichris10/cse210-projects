using System;

class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }

    public string GetDecimalValue()
    {
        return $"{(double)_topNumber / _bottomNumber}";
    }

    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }


}
