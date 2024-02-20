using System;

// Abstracción: La clase Task es abstracta y proporciona una plantilla para tareas genéricas.
abstract class Task
{
    // Encapsulación: Propiedades para acceder y controlar el acceso a los atributos de la clase.
    public string Name { get; set; }
    public bool HasDeadline { get; set; }
    public DateTime Deadline { get; set; }
    public bool Completed { get; set; }

    // Constructor que inicializa los atributos básicos de una tarea.
    public Task(string name, bool hasDeadline, DateTime deadline)
    {
        Name = name;
        HasDeadline = hasDeadline;
        Deadline = hasDeadline ? deadline : DateTime.MinValue;
        Completed = false;
    }

    // Polimorfismo: Método abstracto que se implementará de manera específica en las clases derivadas.
    public abstract void MarkAsCompleted();
}

// Herencia: SimpleTask hereda de la clase base Task.
class SimpleTask : Task
{
    // Constructor que llama al constructor de la clase base para inicializar atributos comunes.
    public SimpleTask(string name, bool hasDeadline, DateTime deadline)
        : base(name, hasDeadline, deadline)
    {
    }

    // Polimorfismo: Implementación específica del método abstracto en SimpleTask.
    public override void MarkAsCompleted()
    {
        Completed = true;
    }
}

// Herencia: RecurringTask hereda de la clase base Task.
class RecurringTask : Task
{
    // Constructor que llama al constructor de la clase base para inicializar atributos comunes.
    public RecurringTask(string name, bool hasDeadline, DateTime deadline)
        : base(name, hasDeadline, deadline)
    {
    }

    // Polimorfismo: Implementación específica del método abstracto en RecurringTask.
    public override void MarkAsCompleted()
    {
        Completed = false; // Las tareas recurrentes no se marcan automáticamente como completadas
    }
}
