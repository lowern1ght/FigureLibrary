﻿using FigureLibrary.Exceptions;
using FigureLibrary.Extensions;

namespace FigureLibrary.Helper;

public static class FigureHelper
{
    #region Common

    /// <summary>
    ///     The number to check, less than which the result is no longer valid
    /// </summary>
    public const double Tolerance = 0.0000001;

    /// <summary>
    ///     Check all sides if one side is not valid that return false
    /// </summary>
    /// <param name="sides"></param>
    /// <returns></returns>
    public static bool SidesIsValidate(params double[] sides)
    {
        foreach (var side in sides)
            if (side.IsLessNull())
                return false;

        return true;
    }

    /// <summary>
    ///     Check sides on validate if one side is not valid that throw exception
    /// </summary>
    /// <param name="sides"></param>
    /// <returns></returns>
    /// <exception cref="SideInitializationException"></exception>
    public static void SidesIsValidateThrow(params double[] sides)
    {
        foreach (var side in sides)
            if (side.IsLessNull())
                throw new SideInitializationException(side);
    }

    #endregion

    #region Triangle

    private const uint TriangleSidesCount = 3;

    /// <summary>
    /// Check sides triangle is validate if one side is not valid that throw exception
    /// </summary>
    /// <param name="sides"></param>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="SideInitializationException"></exception>
    public static void TriangleSidesIsValidThrow(params double[] sides)
    {
        FigureHelper.SidesIsValidateThrow(sides);

        if (sides.Length != TriangleSidesCount)
        {
            throw new InvalidOperationException($"params array count is not {TriangleSidesCount}");
        }
    }

    #endregion
}