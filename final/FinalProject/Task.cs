using System;

abstract class Task
{
    // Abstracción: Creamos un modelo genérico para representar tareas con la clase Task.
    public string Name { get; set; }
    public bool HasDeadline { get; set; }
    public DateTime Deadline { get; set; }
    public bool Completed { get; set; }

    public Task(string name, bool hasDeadline, DateTime deadline)
    {
        Name = name;
        HasDeadline = hasDeadline;
        Deadline = hasDeadline ? deadline : DateTime.MinValue;
        Completed = false;
    }

    // Abstracción: Definimos una acción básica que debe hacer cualquier tipo de tarea.
    public abstract void MarkAsCompleted();
}

// Herencia: Simple Task
class SimpleTask : Task
{
    public SimpleTask(string name, bool hasDeadline, DateTime deadline)
        : base(name, hasDeadline, deadline)
    {
    }

    public override void MarkAsCompleted()
    {
        Completed = true;
    }
}

// Herencia: RecurringTask
class RecurringTask : Task
{
    public RecurringTask(string name, bool hasDeadline, DateTime deadline)
        : base(name, hasDeadline, deadline)
    {
    }

    public override void MarkAsCompleted()
    {
        Completed = false; // Las tareas recurrentes no se marcan como completadas automáticamente
    }
}
