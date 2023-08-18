namespace FigureUnit;

public class RectangleTest
{
    [Theory]
    [InlineData(2, 4)]
    [InlineData(5, 10)]
    [InlineData(8, 12)]
    public void TestArea(Double side1, Double side2)
    {
        var rectangle = new Rectangle(side1, side2);
        Assert.Equal(RectangleArea(ref side1, ref side2), rectangle.Area());
    }

    [Theory]
    [InlineData(-1, 2)]
    [InlineData(10, 0)]
    public void TestExceptionArgument(Double side1, Double side2)
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(side1, side2));
    }

    private Double RectangleArea(ref Double side1, ref Double side2)
    {
        return side1 * side2;
    }
}