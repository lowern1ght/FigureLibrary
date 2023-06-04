namespace FigureLibrary.Models.Figure;

public class Triangle : ITriangle
{
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }

    public Triangle(Double firstSite, Double secondSite, Double thirdSite)
    {
        if (firstSite > 0 && secondSite > 0 && thirdSite > 0)
        {
            A = firstSite; B = secondSite; C = thirdSite;
        }
        else { throw new ArgumentNullException(); }
    }

    public Boolean IsRectangular()
    {
        return (A * A) == (B * B) + (C * C) ||
               (B * B) == (A * A) + (C * C) ||
               (C * C) == (B * B) + (A * A);
    }
    
    public Double GetSemiPerimeter()
        => Math.Round((A + B + C) / 2, 2);
    
    public Double GetArea()
    {
        var p = GetSemiPerimeter();
        return Math.Round(Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C)), 2);
    }
}
