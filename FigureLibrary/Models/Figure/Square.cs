namespace FigureService.Models.Figure;

public class Square : IFigure
{
    public Double A { get; init; }

    public Square(Double firstSite)
    {
        A = firstSite;
    }
    
    public Double GetArea()
    {
        return A * A;
    }
}
