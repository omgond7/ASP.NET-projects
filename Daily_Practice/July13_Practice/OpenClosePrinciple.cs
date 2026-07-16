//Open to extension and closed to modification

interface IPay
{
    void pay();
}
class UPI : IPay
{
    public void pay()
    {
        Console.WriteLine("Paid Using UPI");
    }
}
class CreditCard : IPay
{
    public void pay()
    {
        Console.WriteLine("Paid Using Credit Card");
    }
}
class Netbanking: IPay
{
    public void pay()
    {
        Console.WriteLine("Paid Using Netbanking");
    }
}
class OpenCloseDemo
{
    public static void Run()
    {
        IPay ip = new UPI();
        ip.pay();
    }
}