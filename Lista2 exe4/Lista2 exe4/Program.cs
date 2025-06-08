using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo;
            double alturaRetangulo;
            double area; 

            Console.WriteLine("Exercício 4: Área do Retângulo");

            Console.WriteLine("Vamos calcular a área de um retângulo.");

            Console.Write("Digite o valor da BASE do retângulo: ");
            baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da ALTURA do retângulo: ");
            alturaRetangulo = double.Parse(Console.ReadLine());

            // Calcula a área
            area = baseRetangulo * alturaRetangulo;
            Console.WriteLine("A área do retângulo é: " + area);
            // Verifica se o terreno é grande
            if (area > 100)
            {
                Console.WriteLine("Mensagem: Terreno grande");
            }
            Console.WriteLine("\nFim do Exercício 4.");
            Console.ReadKey();
        }
    }
}
