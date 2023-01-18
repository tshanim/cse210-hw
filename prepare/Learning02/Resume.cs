using System;

public class Resume
{
    public string _name;
    
    // Initialize the list to a new list before using it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Use custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            //Call the Display method on each job
            job.Display();
        }
    }
}