using FigureLibrary.Models.Interfaces;

namespace FigureLibrary.Models.Figure;

public class Triangle : ITriangle
{
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }
    
    /// <param name="firstSite">first side of triangle</param>
    /// <param name="secondSite">second side of triangle</param>
    /// <param name="thirdSite">third side of triangle</param>
    /// <exception cref="ArgumentException">if side('s) is less than 0 or equal to 0</exception>
    public Triangle(Double firstSite, Double secondSite, Double thirdSite)
    {
        if (firstSite > 0 && secondSite > 0 && thirdSite > 0)
        {
            A = firstSite; B = secondSite; C = thirdSite;
        }
        else { throw new ArgumentException("Argument('s) must be greater than zero"); }

        if (firstSite + secondSite < thirdSite ||
            secondSite + thirdSite < firstSite ||
            firstSite + thirdSite < secondSite)
        {
            throw new ArgumentException("Side cannot be greater than the sum of the other two");
        }
    }

    public Boolean IsRectangular()
    {
        return Math.Round(A * A, 2) == Math.Round(B * B, 2) + Math.Round(C * C, 2) ||
               Math.Round(B * B, 2) == Math.Round(A * A, 2) + Math.Round(C * C, 2) ||
               Math.Round(C * C, 2) == Math.Round(B * B, 2) + Math.Round(A * A, 2);
    }
    
    /// <returns>get semi-perimeter this triangle</returns>
    public Double GetSemiPerimeter()
        => (A + B + C) / 2;
    
    public Double GetArea()
    {
        var semiPerimeter = GetSemiPerimeter();
        return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
    }
}
