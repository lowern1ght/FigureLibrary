using FigureLibrary.Interfaces;

namespace FigureLibrary;

public readonly struct Rectangle : IFigure
{
    private readonly Double _side1;
    private readonly Double _side2;

    /// <summary>
    ///     Create a new struct rectangle
    /// </summary>
    /// <param name="side1"></param>
    /// <param name="side2"></param>
    /// <exception cref="ArgumentException">if one side equal null</exception>
    public Rectangle(double side1, double side2)
    {
        if (side1 <= 0.0)
        {
            throw new ArgumentException(nameof(side1));
        }
        
        if (side2 <= 0.0)
        {
            throw new ArgumentException(nameof(side2));
        }
        
        _side1 = side1;
        _side2 = side2;
    }
    
    public double Area()
    {
        return _side1 * _side2;
    }
}