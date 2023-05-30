namespace FigureLibrary.Models.Figure;

public class Square : IFigure
{
    public Double A { get; init; }

    public Square(Double firstSite) 
        => A = firstSite;

    public Double GetArea() 
        => Math.Pow(A, 2);
}
