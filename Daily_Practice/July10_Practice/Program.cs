//Om Prashant Gond IT SSGMCE July 10
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("July 10 Practice Menu ");
        Console.WriteLine("1. Run Delegate Demo");
        Console.WriteLine("2. Run Lambda Expression Demo");
        Console.WriteLine("3. Linqeg");
        Console.WriteLine("4. Run Exception Handling Demo");
        Console.WriteLine("5. Run Custom Exception Demo");
        Console.Write("Enter your choice : ");
        
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
        else if(choice == "3"){
            Linqeg linqDemo = new Linqeg();
            linqDemo.Run();
        }
        else if(choice == "4"){
            ExceptionHandelingDemo exceptions = new ExceptionHandelingDemo();
            exceptions.Run();
        }
        else if(choice == "5"){
            CustomException customExceptionDemo = new CustomException();
            customExceptionDemo.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting");
        }
    }
}
