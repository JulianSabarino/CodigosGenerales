using System;

namespace Cual_es_el_valor_de____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = '⊕';
            char caracter = (char)suma;

            Console.WriteLine($"{caracter}={suma}");
            if (caracter == '⊕')
                Console.WriteLine($"El ⊕ = {caracter},valor {suma}");
            else
                Console.WriteLine($"El ⊕ != {caracter}, valor {suma}");
        }
    }
}
