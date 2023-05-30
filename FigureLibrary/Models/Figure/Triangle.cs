namespace FigureService.Models.Figure;

public class Triangle : ITriangle
{
    public Double A { get; init; }
    public Double B { get; init; }
    public Double C { get; init; }

    public Triangle(Double firstSite, Double secondSite, Double thirdSite)
    {
        A = firstSite;
        B = secondSite;
        C = thirdSite;
    }
    
    public Boolean IsRectangular()
    {
        return (A * A) == (B * B) + (C * C) ||
               (B * B) == (A * A) + (C * C) ||
               (C * C) == (B * B) + (A * A);
    }

    public Double GetSemiPerimeter()
    {
        return (A + B + C) / 2;
    }

    public Double GetArea()
    {
        var P = GetSemiPerimeter();
        return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
    }
}
