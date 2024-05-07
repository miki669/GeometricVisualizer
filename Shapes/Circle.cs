namespace GeometricShapes;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Display()
    {
        Console.WriteLine($"Circle with radius {Radius}. Area: {GetArea():F2}");
    }
}