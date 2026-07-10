//Om Prashant Gond IT SSGMCE July 9
using System;

public class PayPalPayment : PaymentProcessor
{
    public override string PaymentMethodName => "PayPal";

    private string email;
    private string password;

    public PayPalPayment(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public override bool Validate()
    {
        if (!email.Contains("@") || !email.Contains("."))
        {
            Console.WriteLine("Error: Invalid PayPal email address format.");
            return false;
        }

        if (string.IsNullOrEmpty(password) || password.Length < 6)
        {
            Console.WriteLine("Error: Password must be at least 6 characters.");
            return false;
        }

        return true;
    }

    public override void Process(double amount)
    {
        Console.WriteLine($"Logging into PayPal for {email} and processing ₹{amount:F2}...");
    }
}
