using FigureLibrary.Models.Interfaces;

namespace FigureLibrary.Models.Figure; 

public class Rectangle : IFigure
{
    private Double A { get; init; }
    private Double B { get; init; }

    public Rectangle(Double firstSite, Double secondSite)
    {
        if (firstSite > 0 && secondSite > 0)
        {
            A = firstSite; B = secondSite;
        }
        else { throw new ArgumentException("Argument('s) must be greater than zero"); }
    }
    
    public Double GetArea() 
        => A * B;
}
