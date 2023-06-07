namespace FigureLibraryUnit;

public class SquareTest
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-8)]
    [InlineData(-0.1)]
    public void TestBadValueSide(Double side)
    {
        Assert.Throws<ArgumentException>(()
            => new Square(side));
    }

    [Theory]
    [InlineData(4, 16)]
    [InlineData(8, 64)]
    [InlineData(12, 144)]
    [InlineData(12.82, 164.3524)]
    //Verification source - windows calculator
    public void TestGetAreaMethod(Double side, Double res)
    {
        var square = new Square(side);
        Assert.Equal(Math.Round(res, 2), Math.Round(square.GetArea(), 2));
    }
}