namespace FigureLibrary.Exceptions;

public class SideInitializationException : Exception
{
    public SideInitializationException(double side)
        : base($"Error init side: {side}")
    {
    }
}