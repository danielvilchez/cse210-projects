// PASO 5: Crear la clase WritingAssignment
// La clase WritingAssignment hereda la clase base Assignment.
public class WritingAssignment : Assignment
{
    // agregar un nuevo atributo privado específico de WritingAssignment llamado _title.
    private string _title;

    // constructor para la clase WritingAssignment que toma tres parámetros (2 heredados de la clase base y 1 específico de WritingAssignment).
    // utilizar la palabra clave 'base' para llamar al constructor de la clase base (Assignment) con los parámetros correspondientes.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Here we set any variables specific to the WritingAssignment class
        _title = title;
    }

    // GetWritingInformation() devuelve una cadena formateada con la información específica de la tarea de escritura.
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}