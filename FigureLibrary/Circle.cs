using FigureLibrary.Interfaces;

namespace FigureLibrary;

public readonly struct Circle : IFigure
{
    private readonly Double _radius;

    /// <summary>
    ///     Create new Circle struct
    /// </summary>
    /// <exception cref="ArgumentException">if radius is null</exception>
    public Circle(double radius)
    {
        if (radius <= 0.0)
        {
            throw new ArgumentException(nameof(radius));
        }
        
        _radius = radius;
    }
    
    public double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}