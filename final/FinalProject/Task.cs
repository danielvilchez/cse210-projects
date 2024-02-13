using System;

class Task
{
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
}
