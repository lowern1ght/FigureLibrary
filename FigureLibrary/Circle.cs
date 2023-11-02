using FigureLibrary.Exceptions;
using FigureLibrary.Helper;
using FigureLibrary.Interfaces;
using static System.Math;

namespace FigureLibrary;

public class Circle : IFigure
{
    private readonly double _radius;

    /// <summary>
    ///     Create new Circle
    /// </summary>
    /// <exception cref="SideInitializationException">if radius is null or less null</exception>
    public Circle(double radius)
    {
        FigureHelper.SidesIsValidateThrow(radius);

        _radius = radius;

        #region Area

        Area = PI * Pow(_radius, 2);

        #endregion
    }

    public double Area { get; init; }
}