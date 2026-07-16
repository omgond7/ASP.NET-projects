using System;

interface IEngine
{
    void Start();
}

class PetrolEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Petrol engine started (vroom vroom!).");
    }
}

class DieselEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Diesel engine started (rumble rumble!).");
    }
}

class Car
{
    private readonly IEngine _engine;

    // Dependency injection via Constructor
    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void StartCar()
    {
        _engine.Start();
        Console.WriteLine("Car is ready to drive.");
    }
}

class DependencyInversionDemo
{
    public static void Run()
    {
        Console.WriteLine("Creating a car with a Petrol Engine:");
        IEngine petrol = new PetrolEngine();
        Car petrolCar = new Car(petrol);
        petrolCar.StartCar();

        Console.WriteLine("\nCreating a car with a Diesel Engine:");
        IEngine diesel = new DieselEngine();
        Car dieselCar = new Car(diesel);
        dieselCar.StartCar();
    }
}
