using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Run Student Details Demo");
        Console.WriteLine("2. Run Collections Demo");
        Console.Write("Enter your choice 1 or 2: ");
        
        string? choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1")
        {
            Student student1 = new Student
            {
                Name = "Om",
                RollNumber = 112,
                Gender = 'M',
                DOB = "05032006",
                Height = 176,
                College = "SSGMCE"
            };

            student1.DisplayDetails();
        }
        else if (choice == "2")
        {
            Collections collectionsDemo = new Collections();
            collectionsDemo.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
        }
    }
}
