using System;

public class Square : Shape
{
    private int sideLength;
    public Square(int sidelength, string type) : base(type)
    {
        this.sideLength = sidelength;
    } 
    public override int surface_area()
    {
        return sideLength * sideLength;
    }
    public override int perimeter()
    {
        return 4 * sideLength;
    }
}
