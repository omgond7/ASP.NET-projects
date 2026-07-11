//Om Prashant Gond IT SSGMCE July 10
using System;

class CustomException
{
    static void CheckAge(int age)
    {
        if (age < 20)
        {
            throw new InvalidAgeException("Age should be above 20 for driving.");
        }

        Console.WriteLine("Age is 20 and above, eligible for drive");
    }

    public void Run()
    {
        try
        {
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}