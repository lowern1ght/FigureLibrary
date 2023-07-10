using FigureLibrary.Models.Interfaces;

namespace FigureLibrary.Models.Figure;

public abstract class Figure : IFigure
{
    public virtual double GetArea()
        => Double.MinValue;
}