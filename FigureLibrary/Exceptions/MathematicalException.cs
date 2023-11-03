namespace FigureLibrary.Exceptions;

public class MathematicalException : Exception
{
    protected MathematicalException(string? message)
        : base(message ?? string.Empty)
    { }
}