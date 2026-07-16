using System;

class Bird
{
    public void Eat()
    {
        Console.WriteLine("Bird is eating.");
    }
}

interface IFlyable
{
    void Fly();
}

class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying.");
    }
}

class Penguin : Bird
{
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming.");
    }
}

class LiskovSubstitutionDemo
{
    public static void Run()
    {
        Bird bird1 = new Sparrow();
        Bird bird2 = new Penguin();

        bird1.Eat();
        bird2.Eat();

        IFlyable flyer = new Sparrow();
        flyer.Fly();
    }
}
