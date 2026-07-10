//Om Prashant Gond IT SSGMCE July 9
using System;

public class Transaction
{
    public string TransactionId { get; }
    public double Amount { get; }
    public string PaymentMethod { get; }
    public bool IsSuccessful { get; }
    public string Message { get; }
    public DateTime Timestamp { get; }

    public Transaction(string transactionId, double amount, string paymentMethod, bool isSuccessful, string message)
    {
        TransactionId = transactionId;
        Amount = amount;
        PaymentMethod = paymentMethod;
        IsSuccessful = isSuccessful;
        Message = message;
        Timestamp = DateTime.Now;
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Payment Receipt");
        Console.WriteLine($"Transaction ID : {TransactionId}");
        Console.WriteLine($"Date: {Timestamp}");
        Console.WriteLine($"Payment Method: {PaymentMethod}");
        Console.WriteLine($"Amount: ₹ {Amount:F2}");
        Console.WriteLine($"Status: {(IsSuccessful ? "Success" : "Failed")}");
        Console.WriteLine($"Message: {Message}");
    }
}
