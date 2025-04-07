using System;
using System.Globalization;

namespace cursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {

            double baseRet, heightRet, areaRet, perimeterRet, diagonalRet;

            Console.WriteLine("Qual a base do retângulo?");
            baseRet = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a altura do retângulo?");
            heightRet = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            areaRet = baseRet * heightRet;
            Console.WriteLine("Área do retângulo: " + areaRet.ToString("F4"));
            perimeterRet = baseRet * 2 + heightRet * 2;
            Console.WriteLine("Perímetro do retângulo: " + perimeterRet.ToString("F4"));
            diagonalRet = Math.Sqrt((Math.Pow(baseRet, 2) + Math.Pow(heightRet, 2)));
            Console.WriteLine("Diagonal do retângulo: " + diagonalRet.ToString("F4"));

        }
    }
}