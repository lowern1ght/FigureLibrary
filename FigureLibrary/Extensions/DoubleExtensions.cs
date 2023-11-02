namespace FigureLibrary.Extensions;

public static class DoubleExtensions
{
    public static bool IsNull(this double d)
    {
        return d == 0.0;
    }

    public static bool IsLessNull(this double d)
    {
        return d <= 0.0;
    }
}