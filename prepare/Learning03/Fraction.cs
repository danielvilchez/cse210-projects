using System;

// PASO 3: Crear la clase 'Fraction'
public class Fraction
{
    // atributos para los números superior e inferior
    private int _top; // Numerador
    private int _bottom; // Denominador

    // Este constructo se llama automáticamente cuando se crea una nueva instancia de la clase
    public Fraction()
    {
        // Inicializa la fracción a 1/1 por defecto
        _top = 1;
        _bottom = 1;
    }

    // creamos otro constructor que permite inicializar la fracción con un número entero
    // por ejemplo, 5 se convierte en 5/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // permite inicializar la fracción con un numerador y un denominador especificos
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // devuelve una represantación de cadena de la fracción 
    // por ejemplo: 3/4, te devolverá la cadena "3/4"
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // 'double' permite numeros decimales
        return (double)_top / (double)_bottom;
    }
}