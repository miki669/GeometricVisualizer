namespace GeometricShapes;

public class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }

    public override void Display()
    {
        Console.WriteLine($"Square with side length {SideLength}. Area: {GetArea():F2}");
    }
}