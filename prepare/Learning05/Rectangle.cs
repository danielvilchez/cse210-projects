public class Rectangle : Shape
{
    // almacenar las dimensiones del rectángulo.
    private double _length;
    private double _width;

    // inicializar el color y las dimensiones del rectángulo.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Se anula el método abstracto GetArea() para proporcionar la implementación específica del área para un rectángulo.
    public override double GetArea()
    {
        return _length * _width;
    }
}