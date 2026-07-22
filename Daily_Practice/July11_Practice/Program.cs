using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Update Salary");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice (1-6): ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter ID : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Employee ID already exists.");
                            break;
                        }

                        Console.Write("Enter Name : ");
                        string name = Console.ReadLine() ?? "";

                        Console.Write("Enter Monthly Salary : ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        employees.Add(new Employee(id, name, salary));

                        Console.WriteLine("Employee Added Successfully.");
                        break;

                    case 2:

                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No Employees Found.");
                        }
                        else
                        {
                            foreach (Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Enter Employee ID : ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee Not Found.");
                        }

                        break;

                    case 4:

                        Console.Write("Enter Employee ID to Delete : ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        Employee? deleteEmp = null;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == deleteId)
                            {
                                deleteEmp = emp;
                                break;
                            }
                        }

                        if (deleteEmp != null)
                        {
                            employees.Remove(deleteEmp);
                            Console.WriteLine("Employee Deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Employee Not Found.");
                        }

                        break;

                    case 5:

                        Console.Write("Enter Employee ID : ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        bool updated = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == updateId)
                            {
                                Console.Write("Enter New Monthly Salary : ");
                                emp.MonthlySalary = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Salary Updated.");
                                updated = true;
                                break;
                            }
                        }

                        if (!updated)
                        {
                            Console.WriteLine("Employee Not Found.");
                        }

                        break;

                    case 6:

                        Console.WriteLine("Thank You.");
                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Valid Number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}