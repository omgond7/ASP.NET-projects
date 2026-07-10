//Om Prashant Gond IT SSGMCE July 10
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("July 10 Practice Menu ");
        Console.WriteLine("1. Run Delegate Demo");
        Console.WriteLine("2. Run Lambda Expression Demo");
        Console.Write("Enter your choice 1 or 2: ");
        
        string? choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1")
        {
            Delegateeg delegateDemo = new Delegateeg();
            delegateDemo.Run();
        }
        else if (choice == "2")
        {
            LambdaExpDemo lambdaDemo = new LambdaExpDemo();
            lambdaDemo.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting");
        }
    }
}
