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
        else { throw new ArgumentNullException(); }
    }

    public Double GetArea() 
        => Math.Pow(A, 2);
}
