public class Circle : Shape
{
    private int diameter;
    private int radius;
    public Class1(int diameter, string type) : base(type)
    {
        this.diameter = diameter;
        this.radius = diameter / 2;
    }
    public override int surface_area()
    {
        return 3.142 * radius ^ 2;
    }
    public override int perimeter()
    {
        return 3.142 * diameter;
    }
}
