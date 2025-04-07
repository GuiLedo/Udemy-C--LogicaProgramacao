using System;
using System.Globalization;

namespace cursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double idadeMedia;

            Console.WriteLine("Favor fornecer nome e idade da P1:");
            string[] vet1 = Console.ReadLine().Split(' ');
            nome1 = vet1[0];
            idade1 = int.Parse(vet1[1]);

            Console.WriteLine("Favor fornecer nome e idade da P2:");
            string[] vet2 = Console.ReadLine().Split(' ');
            nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);

            Console.WriteLine("Nomes: " + vet1[0] + " e " + vet2[0]);
            idadeMedia = (double) (idade1 + idade2) / 2.0;
            Console.WriteLine("Idade Média: " + idadeMedia);

        }
    }
}