// PASO 4: Crear la clase MathAssignment
// crear una nueva clase llamada MathAssignment y que herede la clase base Assignment
public class MathAssignment : Assignment
{
    // Agregar dos atributos privados adicionales (_textbookSection y _problems)
    private string _textbookSection;
    private string _problems;

    // constructor para la clase MathAssignment que acepta cuatro parámetros (2 heredados de la clase base y 2 específicos de MathAssignment)
    // : base(studentName, topic) en el constructor de MathAssignment se utiliza para llamar al constructor de la clase base (Assignment)
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // asignar los valores de los parámetros específicos de MathAssignment a los atributos correspondientes.
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // GetHomewrok() devuelve una cadena formateada con la información específica de las tareas de matemáticas.
    public string GetHomework()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}