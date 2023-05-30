namespace FigureLibrary.Models.Figure;

public class Square : IFigure
{
    public Double A { get; init; }

    public Square(Double firstSite)
    {
        this.A = firstSite;
    }
    
    public Double GetArea()
    {
        return this.A * this.A;
    }
}
