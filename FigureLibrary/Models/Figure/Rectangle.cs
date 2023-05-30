﻿namespace FigureLibrary.Models.Figure; 

public class Rectangle : IFigure
{
    public Double A { get; init; }
    public Double B { get; init; }

    public Rectangle(Double firstSite, Double secondSite)
    {
         A = firstSite; B = secondSite;
    }
    
    public Double GetArea() 
        => A * B;
}
