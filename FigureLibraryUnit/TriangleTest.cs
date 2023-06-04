namespace FigureLibraryUnit;

public class TriangleTest
{
    [Theory]
    [InlineData(1, 0, 3)]
    [InlineData(1, 2, -1)]
    [InlineData(-3, 12, 8)]
    [InlineData(20, -1, 0)]
    public void TestBadValueSide(Int32 a, Int32 b, Int32 c)
    {
        Assert.Throws<ArgumentException>(() 
            => new Triangle(a, b, c));
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(8, 15, 17, 60)]
    [InlineData(6, 4, 8, 11.61895003862225)]
    [InlineData(13, 18, 23, 116.65333257134148)]
    [InlineData(23, 12.2, 15.1, 83.88921679065797)]
    [InlineData(2.3, 1.4, 3.2, 1.4259536282782834)]
    [InlineData(3.6, 4.82, 5.01, 8.220889918030467)]
    [InlineData(12.81, 10.2, 12.43, 58.83142408747214)]
    //Verification source - https://ru.onlinemschool.com/math/assistance/figures_area/triangle/
    public void TestGetAreaMethod(Double a, Double b, Double c, Double res)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(Math.Round(res, 2), Math.Round(triangle.GetArea(), 2));
    }
}