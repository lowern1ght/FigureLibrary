using static System.Math;
using FigureLibrary.Interfaces;

namespace FigureLibrary;

public readonly struct Triangle : IFigure
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    /// <summary>
    ///     Create a new triangle
    /// </summary>
    /// <param name="side1">first side</param>
    /// <param name="side2">second side</param>
    /// <param name="side3">third side</param>
    /// <exception cref="ArgumentException">if one side equal 0</exception>
    public Triangle(double side1, double side2, double side3)
    {
        if (side1 <= 0.0)
        {
            throw new ArgumentException(nameof(side1));
        }
        
        if (side2 <= 0.0)
        {
            throw new ArgumentException(nameof(side2));
        }
        
        if (side3 <= 0.0)
        {
            throw new ArgumentException(nameof(side3));
        }
        
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }
    
    public double HalfPerimeter()
        => (_side1 + _side2 + _side3) / 2;

    public Boolean IsRectangular()
    {
        double[] array = { _side1, _side2, _side3 };
        Array.Sort(array);

        return Pow(array[0], 2) + Pow(array[1], 2) == Pow(array[2], 2);
    }
    
    public double Area()
    {
        var halfPerimeter = HalfPerimeter();
        return Sqrt(halfPerimeter * (halfPerimeter - _side1) 
                                  * (halfPerimeter - _side2) 
                                  * (halfPerimeter - _side3));
    }
}