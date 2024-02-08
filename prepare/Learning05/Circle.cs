public class Circle : Shape
{
    // almacenar el radio del circulo.
    private double _radius;


    // inicializar el color y las dimensiones del rectángulo.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Se anula el método abstracto GetArea() para proporcionar la implementación específica del área para un circulo.
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}