using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        // llamar al método para obtener el resumen y luego muéstrelo en la pantalla.
        Assignment a1 = new Assignment("Samuel Benetti", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // llamar al método para obtener la sección y los problemas
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomework());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }

}