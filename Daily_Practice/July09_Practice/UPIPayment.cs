//Om Prashant Gond IT SSGMCE July 9
using System;

public class UPIPayment : PaymentProcessor
{
    public override string PaymentMethodName => "UPI";

    private string upiId;

    public UPIPayment(string upiId)
    {
        this.upiId = upiId;
    }

    public override bool Validate()
    {
        if (!upiId.Contains("@"))
        {
            Console.WriteLine("Error: UPI ID must contain '@' symbol (e.g. user@bank).");
            return false;
        }

        return true;
    }

    public override void Process(double amount)
    {
        Console.WriteLine($"Requesting payment of ₹{amount:F2} from UPI address '{upiId}'...");
    }
}
