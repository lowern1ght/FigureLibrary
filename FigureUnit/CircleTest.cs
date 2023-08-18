namespace FigureUnit;

public class CircleTest
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(8)]
    public void TestArea(Double radius)
    {
        var circle = new Circle(radius);
        Assert.Equal(CircleArea(ref radius), circle.Area());
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void TestExceptionArgument(Double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    private Double CircleArea(ref Double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}