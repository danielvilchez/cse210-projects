using System;

public class Resume
{
    public string _name;


    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Job: Indica el tipo de elementos contenidos en la lista _jobs
        // job: Es una variable que toma el valor de cada elemento de la lista _jobs
        foreach (Job job in _jobs)
        {
            // mostrar la información específica del trabajo actual en la consola
            job.Display();
        }
    }
}