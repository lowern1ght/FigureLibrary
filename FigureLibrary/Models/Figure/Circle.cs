namespace FigureLibrary.Models.Figure;

public class Circle : IRound
{
    public Double Radius { get; init; }

    public Circle(Double radius)
    {
        this.Radius = radius;
    }
    
    public Double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}