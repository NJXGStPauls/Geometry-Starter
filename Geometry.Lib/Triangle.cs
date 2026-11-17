namespace Geometry.Lib;

public class Triangle
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    // One side only: assume an equilateral triangle
    public Triangle(double side) : this(side, side, side)
    {
    }

    public double SideA
    {
        get { return _sideA; }
        set { _sideA = CheckLength(value); }
    }

    public double SideB
    {
        get { return _sideB; }
        set { _sideB = CheckLength(value); }
    }

    public double SideC
    {
        get { return _sideC; }
        set { _sideC = CheckLength(value); }
    }

    public int NumberOfSides => 3;

    public double LongestSide
    {
        get { return Math.Max(_sideA, Math.Max(_sideB, _sideC)); }
    }

    public double Perimeter()
    {
        return _sideA + _sideB + _sideC;
    }

    public override string ToString()
    {
        return $"Triangle with sides {_sideA}, {_sideB} and {_sideC}";
    }

    private static double CheckLength(double length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("A side length must be greater than zero.");
        }
        return length;
    }
}
