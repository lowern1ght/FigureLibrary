namespace FigureLibrary.Models; 

public interface ITriangle : IFigure
{
    public Double A { get; init; }
    public Double B { get; init; }
    public Double C { get; init; }
}
