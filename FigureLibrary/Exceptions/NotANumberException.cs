namespace FigureLibrary.Exceptions;

public class NotANumberException : MathematicalException
{
    public NotANumberException()
        : base(string.Empty)
    { }
}