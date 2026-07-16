using System;


interface IWorkable
{
    void Work();
}

interface IEatable
{
    void Eat();
}

class HumanWorker : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Human worker is working.");
    }

    public void Eat()
    {
        Console.WriteLine("Human worker is eating lunch.");
    }
}

class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot worker is working (no charging/eating needed).");
    }
}

class InterfaceSegregationDemo
{
    public static void Run()
    {
        Console.WriteLine("Creating Human Worker:");
        HumanWorker human = new HumanWorker();
        human.Work();
        human.Eat();

        Console.WriteLine("\nCreating Robot Worker:");
        RobotWorker robot = new RobotWorker();
        robot.Work();
    }
}
