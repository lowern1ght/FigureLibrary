namespace FigureLibraryUnit;

public class RectangleTest
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(12, -1)]
    [InlineData(-8, 12)]
    [InlineData(-0.1, 2)]
    public void TestBadValueSide(Double firstSide, Double secondSide)
    {
        Assert.Throws<ArgumentException>(()
            => new Rectangle(firstSide, secondSide));
    }

    [Theory]
    [InlineData(4, 3, 12)]
    [InlineData(8, 2, 16)]
    [InlineData(12, 4, 48)]
    //Verification source - windows calculator
    public void TestGetAreaMethod(Double firstSide, Double secondSide, Double res)
    {
        var rectangle = new Rectangle(firstSide, secondSide);
        Assert.Equal(Math.Round(res, 2), Math.Round(rectangle.GetArea(), 2));
    }
}