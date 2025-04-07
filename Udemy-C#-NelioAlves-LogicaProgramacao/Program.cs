using System;
using System.Globalization;

namespace cursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double idadeMedia;

            Console.WriteLine("Favor fornecer nome e idade da P1:");
            string[] vet1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Favor fornecer nome e idade da P2:");
            string[] vet2 = Console.ReadLine().Split(' ');

            Console.WriteLine("Nomes: " + vet1[0] + " e " + vet2[0]);
            idadeMedia = (double.Parse((vet1)[1]) + double.Parse((vet2)[1])) / 2;
            Console.WriteLine("Idade Média: " + idadeMedia);

        }
    }
}