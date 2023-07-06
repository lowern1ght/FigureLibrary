namespace FigureLibraryUnit;

public class NonThinkCheck
{
    [Fact]
    public void CheckRuntime()
    {
        Figure circle = new Circle(20);
        Assert.Equal(Math.Round(circle.GetArea(), 2), Math.Round(1256.6370614359173, 2));

        Figure square = new Square(18);
        Assert.Equal(Math.Round(square.GetArea(), 2), Math.Round(Math.Pow(18, 2), 2));

        Figure triangle = new Triangle(5, 12, 8);
        Assert.Equal(Math.Round(triangle.GetArea(), 2), Math.Round(14.523687548277813, 2));
    }
}