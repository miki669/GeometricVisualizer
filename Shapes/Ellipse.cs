namespace GeometricShapes;

public class Ellipse : Shape
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }
    public Ellipse(double majorAxis, double minorAxis)
    {
        MajorAxis = majorAxis;
        MinorAxis = minorAxis;
    }
    public override double GetArea()
    {
        return Math.PI * MajorAxis * MinorAxis;
    }
    public override void Display()
    {
        Console.WriteLine($"Ellipse with major axis {MajorAxis} and minor axis {MinorAxis}. Area: {GetArea():F2}");
    }
}