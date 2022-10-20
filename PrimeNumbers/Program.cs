

using PrimeNumbers;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        PrimeNumbers.PrimeNumbers p1 = new();
        Console.WriteLine(String.Join(", ", p1.GetNumbers()));
    }
}