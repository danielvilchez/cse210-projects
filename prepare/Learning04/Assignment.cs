// PASO 3: Crear la Clase Base
public class Assignment
{
    // declarar dos atributos privados: _studentName y _topic.
    private string _studenName;
    private string _topic;

    // constructor que acepte el nombre del estudiante y el tema como parámetros y establezca los atributos de la clase
    public Assignment(string studentName, string topic)
    {
        _studenName = studentName;
        _topic = topic;
    }

    // Agrega métodos públicos para acceder a los atributos privados. 
    //Esto se hace para que puedan ser utilizados fuera de la clase y también por las clases derivadas.
    public string GetStudentName()
    {
        return _studenName;
    }
    
    public string GetTopic()
    {
        return _topic;
    }

    // Agrega el método GetSummary() que devuelve el nombre del estudiante y el tema.
    public string GetSummary()
    {
        return _studenName + " - " + _topic;
    }
}