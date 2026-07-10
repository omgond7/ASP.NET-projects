//Om Prashant Gond IT SSGMCE July 9
using System;
using System.Collections.Generic;

public class PaymentGatewayDemo
{
    private static List<Transaction> history = new List<Transaction>();

    public static void Run()
    {
        Console.WriteLine(" Payment Gateway ");
        
        double amount = 0;
        while (true)
        {
            Console.Write("Enter amount to pay (₹): ");
            string? input = Console.ReadLine();
            if (double.TryParse(input, out amount) && amount > 0)
            {
                break;
            }
            Console.WriteLine("Please enter a valid amount greater than zero");
        }

        Console.WriteLine("Choose Payment Method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. PayPal");
        Console.WriteLine("3. UPI");
        string? choice = Console.ReadLine();
        Console.WriteLine();

        PaymentProcessor? processor = null;

        if (choice == "1")
        {
            Console.Write("Enter Card Number (16 digit): ");
            string cardNumber = Console.ReadLine() ?? "";
            Console.Write("Enter Name: ");
            string cardHolderName = Console.ReadLine() ?? "";
            Console.Write("Enter Expiry Date (MM/YY): ");
            string expiryDate = Console.ReadLine() ?? "";
            Console.Write("Enter CVV (3 digit): ");
            string cvv = Console.ReadLine() ?? "";

            processor = new CreditCardPayment(cardNumber, cardHolderName, expiryDate, cvv);
        }
        else if (choice == "2")
        {
            Console.Write("Enter PayPal Email: ");
            string email = Console.ReadLine() ?? "";
            Console.Write("Enter PayPal Password: ");
            string password = Console.ReadLine() ?? "";

            processor = new PayPalPayment(email, password);
        }
        else if (choice == "3")
        {
            Console.Write("Enter UPI ID: ");
            string upiId = Console.ReadLine() ?? "";

            processor = new UPIPayment(upiId);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        // Generate Transaction ID
        string transactionId = "TXN" + new Random().Next(10000, 99999);

        // Validate and Process
        if (processor.Validate())
        {
            processor.Process(amount);
            Transaction successTxn = new Transaction(transactionId, amount, processor.PaymentMethodName, true, "Payment Completed Successfully");
            history.Add(successTxn);
            successTxn.PrintReceipt();
        }
        else
        {
            Transaction failedTxn = new Transaction(transactionId, amount, processor.PaymentMethodName, false, "Validation Failed");
            history.Add(failedTxn);
            failedTxn.PrintReceipt();
        }

        // Option to display session logs
        Console.Write("Do you want to see history of this session? (y/n): ");
        string? viewHistory = Console.ReadLine();
        if (viewHistory?.ToLower() == "y")
        {
            Console.WriteLine("\n--- Session Transaction History ---");
            foreach (var txn in history)
            {
                string status = txn.IsSuccessful ? "Success" : "Failed";
                Console.WriteLine($"[{txn.Timestamp}] ID: {txn.TransactionId} | Method: {txn.PaymentMethod} | Amount: ₹{txn.Amount:F2} | Result: {status}");
            }
        }
    }
}
