namespace FigureLibraryUnit;

public class UnitTest1
{
    [Fact]
    public void Test1Rectangle()
    {
        var rectangle = new Rectangle(20, 12);
        Assert.Equal(20 * 12, rectangle.GetArea());
    }
    
    [Fact]
    public void TestSquad()
    {
        var square = new Square(8);
        Assert.Equal(Math.Pow(8, 2), square.GetArea());

        Assert.Throws<ArgumentNullException>(() 
            => new Square(0));
    }
    
    [Fact]
    public void TestTriangle()
    {
        var triangle = new Triangle(3.5, 2.1, 2.8);
        
        Assert.True(triangle.IsRectangular());
        Assert.Equal(4.2, triangle.GetSemiPerimeter());
        Assert.Equal(2.94, triangle.GetArea());

        Assert.Throws<ArgumentNullException>(() 
            => new Triangle(0.1, 0, 1));
    }
    
    [Fact]
    public void TestCircle()
    {
        var circle = new Circle(25);
        Assert.Equal(Math.PI * Math.Pow(25, 2), circle.GetArea());
    }
}