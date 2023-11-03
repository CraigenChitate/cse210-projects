using System;
using System.Collections.Generic;
using System.Threading;

// Base Activity class containing common attributes and methods
public class Activity
{
    //using (protected) because we want members to be visible and accessible in subclasses
    protected string name;
    protected int duration;

    public Activity(string name)
    {
        this.name = name;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {name} activity...");
        SetDuration();
        PrepareToBegin();
    }

    public virtual void End()
    {
        Console.WriteLine($"Congratulations! You've completed the {name} activity for {duration} seconds.");
        Finish();
    }
//using (protected) because we want members to be visible and accessible in subclasses
    protected virtual void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);
    }

     protected virtual void Finish()
    {
    
     }
}







