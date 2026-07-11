//Om Prashant Gond IT SSGMCE Task July 10
using System;
using System.Collections.Generic;

public abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int LeaveBalance { get; set; }

    public Employee(int id, string name, string dept)
    {
        EmployeeId = id;
        Name = name;
        Department = dept;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Department: {Department}, Leave Balance: {LeaveBalance} days");
    }

    public abstract void SetLeaveBalance();
}

public class PermanentEmployee : Employee
{
    public PermanentEmployee(int id, string name, string dept) : base(id, name, dept)
    {
        SetLeaveBalance();
    }

    public override void SetLeaveBalance()
    {
        LeaveBalance = 24; 
    }
}

public class ContractEmployee : Employee
{
    public ContractEmployee(int id, string name, string dept) : base(id, name, dept)
    {
        SetLeaveBalance();
    }

    public override void SetLeaveBalance()
    {
        LeaveBalance = 12; 
    }
}

public class LeaveRequest
{
    public int LeaveId { get; set; }
    public int EmployeeId { get; set; }
    public int NumberOfDays { get; set; }
    public string Reason { get; set; }

    public LeaveRequest(int leaveId, int employeeId, int numberOfDays, string reason)
    {
        LeaveId = leaveId;
        EmployeeId = employeeId;
        NumberOfDays = numberOfDays;
        Reason = reason;
    }

    public void DisplayLeave()
    {
        Console.WriteLine($"Leave ID: {LeaveId}, Employee ID: {EmployeeId}, Days: {NumberOfDays}, Reason: {Reason}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new PermanentEmployee(101,"Om Gond", "IT"));
        employees.Add(new PermanentEmployee(102, "Amit", "HR"));
        employees.Add(new ContractEmployee(103,"Rahul", "Sales"));
        employees.Add(new ContractEmployee(104, "Priya", "IT"));

        Console.WriteLine(" Task 2: All Employee Details");
        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
        Console.WriteLine();

        List<LeaveRequest> leaveRequests = new List<LeaveRequest>();
        leaveRequests.Add(new LeaveRequest(1,101, 3, "Sick Leave"));
        leaveRequests.Add(new LeaveRequest(2, 103, 5, "Vacation"));
        leaveRequests.Add(new LeaveRequest(3,104, 2, "Family Emergency"));

        // Task 4: Display all leave requests
        Console.WriteLine(" Task 4: All Leave Requests");
        foreach (var req in leaveRequests)
        {
            req.DisplayLeave();
        }
        Console.WriteLine();

        Console.WriteLine(" Task 5: Permanent Employees Only ");
        foreach (var emp in employees)
        {
            if (emp is PermanentEmployee)
            {
                emp.DisplayDetails();
            }
        }
        Console.WriteLine();

        Console.WriteLine(" Task 6: Find Employee with ID 103 ");
        Employee? foundEmp = employees.Find(e => e.EmployeeId == 103);
        if (foundEmp != null)
        {
            foundEmp.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Employee with ID 103 not found.");
        }
        Console.WriteLine();

        Console.WriteLine($"Task 7: Total number of employees = {employees.Count}");

        Console.WriteLine($"Task 8: Total number of leave requests = {leaveRequests.Count}");
    }
}
