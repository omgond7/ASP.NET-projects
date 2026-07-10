//Om Prashant Gond IT SSGMCE July 9
using System;

public abstract class PaymentProcessor
{
    public abstract string PaymentMethodName { get; }

    public abstract bool Validate();

    public abstract void Process(double amount);
}
