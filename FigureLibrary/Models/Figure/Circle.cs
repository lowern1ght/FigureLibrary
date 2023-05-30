namespace FigureService.Models.Figure;

public class Circle : IRound
{
    public Double Radius { get; init; }

    public Circle(Double radius)
    {
        Radius = radius;
    }
    
    public Double GetArea()
    {
        return Math.PI * (Radius * Radius);
    }
}
