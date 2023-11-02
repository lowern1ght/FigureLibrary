using FigureLibrary.Exceptions;
using FigureLibrary.Helper;
using FigureLibrary.Interfaces;

namespace FigureLibrary;

public class Rectangle : IFigure
{
    private readonly double _side1, _side2;

    /// <summary>
    ///     Create a new rectangle
    /// </summary>
    /// <param name="side1"></param>
    /// <param name="side2"></param>
    /// <exception cref="SideInitializationException">if one side equal null or less null</exception>
    public Rectangle(double side1, double side2)
    {
        FigureHelper.SidesIsValidateThrow(side1, side2);

        _side1 = side1;
        _side2 = side2;

        #region Area

        Area = side1 * side2;

        #endregion
    }

    public double Area { get; init; }
}