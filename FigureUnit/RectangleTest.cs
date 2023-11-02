using FigureLibrary.Exceptions;

namespace FigureUnit;

public class RectangleTest
{
    [Theory]
    [InlineData(2, 4)]
    [InlineData(5, 10)]
    [InlineData(8, 12)]
    public void TestArea(double side1, double side2)
    {
        var rectangle = new Rectangle(side1, side2);
        Assert.Equal(RectangleArea(ref side1, ref side2), rectangle.Area);
    }

    [Theory]
    [InlineData(-1, 2)]
    [InlineData(10, 0)]
    public void TestExceptionArgument(double side1, double side2)
    {
        Assert.Throws<SideInitializationException>(() => new Rectangle(side1, side2));
    }

    private double RectangleArea(ref double side1, ref double side2)
    {
        return side1 * side2;
    }
}