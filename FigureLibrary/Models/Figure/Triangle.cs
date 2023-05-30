namespace FigureLibrary.Models.Figure;

public class Triangle : ITriangle
{
    public Double A { get; init; }
    public Double B { get; init; }
    public Double C { get; init; }

    public Triangle(Double firstSite, Double secondSite, Double thirdSite)
    {
        A = firstSite; B = secondSite; C = thirdSite;
    }
    
    public Boolean IsRectangular()
    {
        return (this.A * this.A) == (this.B * this.B) + (this.C * this.C) ||
               (this.B * this.B) == (this.A * this.A) + (this.C * this.C) ||
               (this.C * this.C) == (this.B * this.B) + (this.A * this.A);
    }

    public Double GetSemiPerimeter() 
        => Math.Round((A + B + C) / 2, 2);

    public Double GetArea()
    {
        var P = GetSemiPerimeter();
        return Math.Round(Math.Sqrt(P * (P - this.A) * (P - this.B) * (P - this.C)), 2);
    }
}
