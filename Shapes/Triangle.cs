namespace GeometricShapes;

public class Triangle : Shape
{
    public double SideLength { get; set; }

    public Triangle(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double GetArea()
    {
        double height = Math.Sqrt(3) / 2 * SideLength;
        return 0.5 * SideLength * height;
    }

    public override void Display()
    {
        Console.WriteLine($"Triangle with side length {SideLength}. Area: {GetArea():F2}");
    }
}