using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("1. Run Task 1: Package Processor");
        Console.WriteLine("2. Run Task 2: Power Analyzer");
        Console.Write("Enter your choice 1 or 2 ");
        
        string? choice = Console.ReadLine();
        
        Console.WriteLine();
        
        if (choice == "1")
        {
            July07_Task1_PackageProcessor processor = new July07_Task1_PackageProcessor();
            processor.Run();
        }
        else if (choice == "2")
        {
            July07_Task2_PowerAnalyzer analyzer = new July07_Task2_PowerAnalyzer();
            analyzer.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
        }
    }
}
