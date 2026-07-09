using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Run Task 1: Employee Sales");
        Console.WriteLine("2. Run Task 2: Library Books");
        Console.Write("Enter your choice 1 or 2: ");
        
        string? choice = Console.ReadLine();
        
        Console.WriteLine();
        
        if (choice == "1")
        {
            July08_Task1_EmployeeSales task1 = new July08_Task1_EmployeeSales();
            task1.Run();
        }
        else if (choice == "2")
        {
            July08_Task2_LibraryBooks task2 = new July08_Task2_LibraryBooks();
            task2.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
        }
    }
}
