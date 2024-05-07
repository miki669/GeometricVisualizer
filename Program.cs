using GeometricShapes;

var shapes = new Shape[]
{
    new Circle(5),
    new Ellipse(6, 4),
    new Square(4),
    new Triangle(3)
};

foreach (var shape in shapes)
{
    shape.Display();
}