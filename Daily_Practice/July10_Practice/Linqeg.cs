using System;
using System.Linq;

class Linqeg
{
    public void Run()
    {
        int[] numberss = { 8, 7, 6, 4, 1, 8, 7, 8, 3, 9 };

        var even = numberss.Where(x => x % 2 == 0);

        foreach (var n in even)
        {
            Console.WriteLine(n);
        }
    }
}