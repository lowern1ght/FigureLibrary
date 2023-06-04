using FigureLibrary.Models.Interfaces;

namespace FigureLibrary.Models.Figure;

public class Circle : IRound
{
    public Double Radius { get; init; }

    public Circle(Double radius)
    {
        if (radius > 0)
        {
            this.Radius = radius;
        }
        else { throw new ArgumentNullException(); }
    }
    
    public Double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}