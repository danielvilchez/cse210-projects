using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        // Crear una lista de formas (Shapes)
        List<Shape> shapes = new List<Shape>();

        // Crear un cuadrado y agregarlo a la lista
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        // Crear un rectángulo y agregarlo a la lista
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        // Crear un círculo y agregarlo a la lista
        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iterar a través de la lista de formas
        foreach (Shape s in shapes)
        {
            // Obtener el color de la forma
            string color = s.GetColor();

            // Obtener el área de la forma
            double area = s.GetArea();

            // Imprimir información sobre la forma
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}