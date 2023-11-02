using FigureLibrary.Exceptions;
using FigureLibrary.Helper;
using FigureLibrary.Interfaces;
using static System.Math;

namespace FigureLibrary;

public class Triangle : IFigure
{
    private readonly double _side1, _side2, _side3;


    /// <summary>
    ///     Create a new triangle
    /// </summary>
    /// <param name="side1">first side</param>
    /// <param name="side2">second side</param>
    /// <param name="side3">third side</param>
    /// <exception cref="SideInitializationException">if one side equal 0</exception>
    public Triangle(double side1, double side2, double side3)
    {
        FigureHelper.SidesIsValidateThrow(side1, side2, side3);

        _side1 = side1;
        _side2 = side2;
        _side3 = side3;

        #region HalfPerimeter

        HalfPerimeter = (_side1 + _side2 + _side3) / 2;

        #endregion

        #region IsRectangular

        double[] array = { _side1, _side2, _side3 };
        Array.Sort(array);

        IsRectangular = Abs(Pow(array[0], 2) + Pow(array[1], 2) - Pow(array[2], 2)) < FigureHelper.Tolerance;

        #endregion

        #region Area

        Area = Sqrt(HalfPerimeter * (HalfPerimeter - _side1)
                                  * (HalfPerimeter - _side2)
                                  * (HalfPerimeter - _side3));

        #endregion
    }

    public double HalfPerimeter { get; }

    public bool IsRectangular { get; }

    public double Area { get; init; }
}