class Invoice
{
    public double amount{get; set;}

    public Invoice(double amount)
    {
        this.amount = amount;
    }
    public double calculateTax()
    {
        return amount * 0.18;
    }
}
class InvoicePrinter
{
    public void printInvoice(Invoice invoice)
    {
        Console.WriteLine($"Amount is : {invoice.amount}");
        Console.WriteLine($"Tax is :{invoice.calculateTax()}");
    }
}
class SingleResponsibilityDemo
{
    public static void Run()
    {
        Invoice inv = new Invoice(1200000);
        InvoicePrinter printer = new InvoicePrinter();
        printer.printInvoice(inv);
    }
}