//Om Prashant Gond IT SSGMCE July 9
using System;

public class CreditCardPayment : PaymentProcessor
{
    public override string PaymentMethodName => "Credit Card";

    private string cardNumber;
    private string cardHolderName;
    private string expiryDate;
    private string cvv;

    public CreditCardPayment(string cardNumber, string cardHolderName, string expiryDate, string cvv)
    {
        this.cardNumber = cardNumber.Replace(" ", "");
        this.cardHolderName = cardHolderName;
        this.expiryDate = expiryDate;
        this.cvv = cvv;
    }

    public override bool Validate()
    {
        if (cardNumber.Length != 16)
        {
            Console.WriteLine("Error: Card number must be 16 digits.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(cardHolderName))
        {
            Console.WriteLine("Error: Cardholder name cannot be empty.");
            return false;
        }

        if (expiryDate.Length != 5 || !expiryDate.Contains("/"))
        {
            Console.WriteLine("Error: Expiry date must be in MM/YY format.");
            return false;
        }

        if (cvv.Length != 3)
        {
            Console.WriteLine("Error: CVV must be 3 digits.");
            return false;
        }

        return true;
    }

    public override void Process(double amount)
    {
        Console.WriteLine($"Processing credit card payment of ₹{amount:F2} for {cardHolderName}...");
    }
}
