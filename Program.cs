using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola des de VS Code i GitHub!");
        Console.Write("Introdueix un número enter: ");
        int numero;
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            var multiples = Metodes.comptadorMultiples(numero);
            Console.WriteLine($"Hi ha {multiples.Count} Múltiples de 7 menors de {numero}.");
            Console.WriteLine("Aquests són:");
            foreach (var m in multiples)
            {
                Console.WriteLine(m);
            }
        }
        else
        {
            Console.WriteLine("No és vàlid.");
        }
    }
}

public static class Metodes
{
    public static List<int> comptadorMultiples(int v)
    {
        var multiples = new List<int>();
        for (int i = 1; i < v; i++)
        {
            if (i % 7 == 0)
            {
                multiples.Add(i);
            }
        }
        return multiples;
    }
}
