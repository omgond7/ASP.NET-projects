//Om Prashant Gond IT SSGMCE July 10
//delegate - type that holds a reference to a method
//similar to function pointer
//func - returns a value
using System;

delegate void MessageDelegate(string msg);

class Delegateeg
{
    static void Display(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        // Built-in delegate demonstration
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(588, 756));

        // Custom delegate demonstration
        MessageDelegate m = Display;
        m("Hello, i m learning dot net c#");
    }
}
