using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 5;
        int result = Fibonacci(n);
        Console.WriteLine(result);
    }

    static int Fibonacci(int n)
    {
        Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
        Debug.WriteLine($"We are looking for the {n}th number");

        int n1 = 0, n2 = 1, sum;

        for (int i = 2; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
        }

        return n == 0 ? n1 : n2;
    }
}
