using System;
using System.Globalization;

namespace cursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, nf;

            Console.WriteLine("Nota 1º Semestre:");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 2º Semestre:");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nf = n1 + n2;

            Console.WriteLine("NOTA FINAL = " + nf.ToString("F2", CultureInfo.InvariantCulture));
            if (nf >= 60.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
            Console.ReadLine(); 
        }
    }
}