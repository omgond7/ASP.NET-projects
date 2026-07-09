//Om Prashant Gond IT SSGMCE Task 1 Jul8
using System;

class July08_Task1_EmployeeSales
{
    public void Run()
    {
        // Monthly sales in ₹ of 6 employees stored in an array
        double[] sales = { 45000, 52000, 38000, 61000, 49000, 55000 };

        Console.WriteLine("Monthly Sales of 6 Employees:");
        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine($"Employee {i + 1}: ₹ {sales[i]}");
        }

        // Calculations
        double totalSales = 0;
        double highestSales = sales[0];
        double lowestSales = sales[0];

        for (int i = 0; i < sales.Length; i++)
        {
            totalSales += sales[i];

            if (sales[i] > highestSales)
            {
                highestSales = sales[i];
            }

            if (sales[i] < lowestSales)
            {
                lowestSales = sales[i];
            }
        }

        double averageSales = totalSales / sales.Length;

        // Display results
        Console.WriteLine("\n--- Sales Report Summary ---");
        Console.WriteLine($"Total Sales  : ₹ {totalSales}");
        Console.WriteLine($"Average Sales: ₹ {averageSales:F2}");
        Console.WriteLine($"Highest Sales: ₹ {highestSales}");
        Console.WriteLine($"Lowest Sales : ₹ {lowestSales}");
    }
}
