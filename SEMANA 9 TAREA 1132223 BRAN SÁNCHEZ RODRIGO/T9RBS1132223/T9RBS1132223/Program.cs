using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero mayor a 0: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.Write("Por favor, ingrese un número entero mayor a 0: ");
        }

        // Serie 1: (1/1) + (1/2) + (1/3) + ... + (1/numero)
        double serie1 = 0.0;
        for (int i = 1; i <= numero; i++)
        {
            serie1 += 1.0 / i;
        }

        // Serie 2: (1/2^1) + (1/2^2) + (1/2^3) + ... + (1/2^numero)
        double serie2 = 0.0;
        int exponente = 1;
        while (exponente <= numero)
        {
            serie2 += 1.0 / Math.Pow(2, exponente);
            exponente++;
        }

        Console.WriteLine("Serie 1: " + serie1);
        Console.WriteLine("Serie 2: " + serie2);

        Console.ReadLine();
    }
}

