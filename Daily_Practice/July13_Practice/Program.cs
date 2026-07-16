using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("     SOLID Principles Demo");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Single Responsibility Principle (SRP)");
            Console.WriteLine("2. Open/Closed Principle (OCP)");
            Console.WriteLine("3. Liskov Substitution Principle (LSP)");
            Console.WriteLine("4. Interface Segregation Principle (ISP)");
            Console.WriteLine("5. Dependency Inversion Principle (DIP)");
            Console.WriteLine("0. Exit");
            Console.WriteLine("==============================");
            Console.Write("Enter your choice (0-5): ");

            string? choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("--- Running Single Responsibility Principle Demo ---");
                    SingleResponsibilityDemo.Run();
                    break;
                case "2":
                    Console.WriteLine("--- Running Open/Closed Principle Demo ---");
                    OpenCloseDemo.Run();
                    break;
                case "3":
                    Console.WriteLine("--- Running Liskov Substitution Principle Demo ---");
                    LiskovSubstitutionDemo.Run();
                    break;
                case "4":
                    Console.WriteLine("--- Running Interface Segregation Principle Demo ---");
                    InterfaceSegregationDemo.Run();
                    break;
                case "5":
                    Console.WriteLine("--- Running Dependency Inversion Principle Demo ---");
                    DependencyInversionDemo.Run();
                    break;
                case "0":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 0 and 5.");
                    break;
            }
        }
    }
}
