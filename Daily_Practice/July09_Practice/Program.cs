//Om Prashant Gond IT SSGMCE July 9
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== July 9 Practice Menu ===");
        Console.WriteLine("1. Run Student & Teacher Collections Demo");
        Console.WriteLine("2. Run OOP Payment Gateway Demo");
        Console.Write("Enter your choice (1 or 2): ");
        
        string? choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1")
        {
            CollectionsDemo collectionsDemo = new CollectionsDemo();
            collectionsDemo.Run();
        }
        else if (choice == "2")
        {
            PaymentGatewayDemo.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
        }
    }
}
