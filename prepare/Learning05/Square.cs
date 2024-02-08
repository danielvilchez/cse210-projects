public class Square : Shape
{
    // La propiedad _side almacena la longitud de un lado del cuadrado.
    private double _side;

    //  inicializa el color y el lado del cuadrado.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Se anula el método abstracto GetArea() para proporcionar la implementación específica del área para un cuadrado.
    public override double GetArea()
    {
        return _side * _side;
    }
}