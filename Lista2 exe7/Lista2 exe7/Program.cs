using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1;
            double lado2;
            double lado3;

            Console.WriteLine("Vamos verificar se três valores formam um triângulo e qual tipo ele é.");

            Console.Write("Digite o primeiro lado: ");
            lado1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo lado: ");
            lado2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro lado: ");
            lado3 = double.Parse(Console.ReadLine());

            // Verifica existência de triângulo
            // A soma de dois lados deve ser maior que o terceiro lado
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                // Classifica o triângulo
                // Triângulo Equilátero: todos os lados iguais
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Os lados formam um triângulo EQUILÁTERO.");
                }

                // Triângulo Isósceles: dois lados iguais
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Os lados formam um triângulo ISÓSCELES.");
                }
                
                // Triângulo Escaleno: todos os lados diferentes
                else
                {
                    Console.WriteLine("Os lados formam um triângulo ESCALENO.");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados NÃO formam um triângulo.");
            }
            Console.ReadKey();
        }
    }
}
