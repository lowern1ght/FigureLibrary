using FigureLibrary.Exceptions;

namespace FigureUnit;

public class TriangleTest
{
    [Theory]
    [InlineData(11, 12, 13)]
    public void TestArea(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        Assert.Equal(TriangleArea(ref side1, ref side2, ref side3), triangle.Area);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    public void TestIsRectangular(double side1, double side2, double side3, bool isRectangular)
    {
        var triangle = new Triangle(side1, side2, side3);
        Assert.Equal(isRectangular, triangle.IsRectangular);
    }

    [Theory]
    [InlineData(-1, 2, 3)]
    [InlineData(12, 11, 0)]
    [InlineData(-1, -20, 0)]
    public void TestArgumentException(double side1, double side2, double side3)
    {
        Assert.Throws<SideInitializationException>(() => new Triangle(side1, side2, side3));
    }

    private double TriangleArea(ref double side1, ref double side2, ref double side3)
    {
        var semiPerimeter = (side1 + side2 + side3) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - side1)
                                       * (semiPerimeter - side2)
                                       * (semiPerimeter - side3));
    }
}