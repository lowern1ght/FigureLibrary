namespace FigureLibrary.Models.Figure; 

public class Rectangle : IFigure
{
    public Double A { get; init; }
    public Double B { get; init; }

    public Rectangle(Double firstSite, Double secondSite)
    {
        this.A = firstSite;
        this.B = secondSite;
    }
    
    public Double GetArea()
    {
        return this.A * this.B;
    }
}
