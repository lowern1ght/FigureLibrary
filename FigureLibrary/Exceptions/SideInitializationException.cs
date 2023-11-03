namespace FigureLibrary.Exceptions;

public class SideInitializationException : MathematicalException
{
    public SideInitializationException(double side)
        : base($"Error init side: {side}")
    { }
}