//Om Prashant Gond IT SSGMCE July 10
//Lambda expression - shorter way to write anonymous function
//(parameters) => expression
using System;

class LambdaExpDemo
{
    public void Run()
    {
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(6)); // 36

        Func<int, int, int> subbDelegate = (a, b) => a - b;
        Console.WriteLine(subbDelegate(10, 50)); // -40

        // without Lambda
        void subb(int a, int b)
        {
            int res = a - b;
            Console.WriteLine(res);
        }

        subb(50, 20); // 30
    }
}
