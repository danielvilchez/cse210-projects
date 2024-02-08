// Se utiliza una clase base abstracta para definir un comportamiento común para todas las formas.
public abstract class Shape
{
    // almacena el color de la forma.
    private string _color;

    //inicializa el color de la forma.
    public Shape(string color)
    {
        _color = color;
    }

    // devuelve el color de la forma
    public string GetColor()
    {
        return _color;
    }

    // establece el color de la forma
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}