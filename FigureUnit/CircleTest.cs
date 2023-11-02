using FigureLibrary.Exceptions;

namespace FigureUnit;

public class CircleTest
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(8)]
    public void TestArea(double radius)
    {
        var circle = new Circle(radius);
        Assert.Equal(CircleArea(ref radius), circle.Area);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void TestExceptionArgument(double radius)
    {
        Assert.Throws<SideInitializationException>(() => new Circle(radius));
    }

    private double CircleArea(ref double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}