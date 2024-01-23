using System;

// PASO 4: Crear los constructores
class Program
{
    static void Main(string[] args)
    {
        // creamos una fracción por defecto y mostramos su representación como fracción y su valor decimal.
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // hacemos lo mismo pero con un número entero (5)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Crear una fracción con numerador y denominador específicos (3, 4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // // Crear una fracción con numerador y denominador específicos (1, 3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}