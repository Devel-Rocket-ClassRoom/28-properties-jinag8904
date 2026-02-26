using System;

class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;

    public int Area => Width * Height;
    public int Perimeter => 2 * (Width + Height);

    public bool IsSqaure => Width == Height;
}