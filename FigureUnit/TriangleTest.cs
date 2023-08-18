namespace FigureUnit;

public class TriangleTest
{
    [Theory]
    [InlineData(11, 12, 13)]
    public void TestArea(Double side1, Double side2, Double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        Assert.Equal(TriangleArea(ref side1, ref side2, ref side3), triangle.Area());
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    public void TestIsRectangular(Double side1, Double side2, Double side3, Boolean isRectangular)
    {
        var triangle = new Triangle(side1, side2, side3);
        Assert.Equal(isRectangular, triangle.IsRectangular());
    }
    
    [Theory]
    [InlineData(-1, 2, 3)]
    [InlineData(12, 11, 0)]
    [InlineData(-1, -20, 0)]
    public void TestArgumentException(Double side1, Double side2, Double side3)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }

    private Double TriangleArea(ref Double side1, ref Double side2, ref Double side3)
    {
        double semiPerimeter = (side1 + side2 + side3) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) 
                                       * (semiPerimeter - side2) 
                                       * (semiPerimeter - side3));
    }
}