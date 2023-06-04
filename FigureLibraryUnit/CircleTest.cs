namespace FigureLibraryUnit;

public class CircleTest
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-12)]
    public void TestBadValueSide(Double radius)
    {
        Assert.Throws<ArgumentException>(() 
            => new Circle(radius));
    }

    [Theory]
    [InlineData(12, 452.3893421169302)]
    [InlineData(12.6, 498.7592496839155)]
    [InlineData(20.1, 1269.2348479768125)]
    //Verification source - https://allcalc.ru/node/18
    public void TestGetAreaMethod(Double radius, Double res)
    {
        var circle = new Circle(radius);
        Assert.Equal(Math.Round(res, 2), Math.Round(circle.GetArea(), 2));
    }
}