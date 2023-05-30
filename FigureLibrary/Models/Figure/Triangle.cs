namespace FigureLibrary.Models.Figure;

public class Triangle : ITriangle
{
    public Double A { get; init; }
    public Double B { get; init; }
    public Double C { get; init; }

    public Triangle(Double firstSite, Double secondSite, Double thirdSite)
    {
        this.A = firstSite;
        this.B = secondSite;
        this.C = thirdSite;
    }
    
    public Boolean IsRectangular()
    {
        return (this.A * this.A) == (this.B * this.B) + (this.C * this.C) ||
               (this.B * this.B) == (this.A * this.A) + (this.C * this.C) ||
               (this.C * this.C) == (this.B * this.B) + (this.A * this.A);
    }

    public Double GetSemiPerimeter()
    {
        return (this.A + this.B + this.C) / 2;
    }

    public Double GetArea()
    {
        var P = GetSemiPerimeter();
        return Math.Sqrt(P * (P - this.A) * (P - this.B) * (P - this.C));
    }
}
