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
    /// <exception cref="NotANumberException">if area is NaN</exception>
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

        double[] sides = { _side1, _side2, _side3 };
        Array.Sort(sides);

        IsRectangular = Abs(Pow(sides[0], 2) + Pow(sides[1], 2) - Pow(sides[2], 2)) < FigureHelper.Tolerance;

        #endregion

        #region Area

        (side1, side2, side3) = (sides[0], sides[1], sides[2]);

        Area = Sqrt(HalfPerimeter * (HalfPerimeter - side1)
                                  * (HalfPerimeter - side2)
                                  * (HalfPerimeter - side3));

        if (double.IsNaN(Area))
        {
            throw new NotANumberException();
        }

        #endregion
    }

    public double HalfPerimeter { get; }

    public bool IsRectangular { get; }

    public double Area { get; init; }
}