using FigureLibrary.Models.Interfaces;

namespace FigureLibrary.Models.Figure;

public class Square : IFigure
{
    public Double A { get; init; }

    public Square(Double firstSite)
    {
        if (firstSite > 0)
        {
            this.A = firstSite;
        }
        else { throw new ArgumentException("Argument must be greater than zero"); }
    }

    public Double GetArea() 
        => Math.Pow(A, 2);
}
