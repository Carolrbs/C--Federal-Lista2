using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo;
            double area;
            double alturaRetangulo;

            Console.WriteLine("Vamos calcular a área de um Terreno.");

            Console.Write("Digite o valor da BASE do retângulo: ");
            baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da ALTURA do retângulo: ");
            alturaRetangulo = double.Parse(Console.ReadLine());

            area = baseRetangulo * alturaRetangulo;
            Console.WriteLine("A área do retângulo é: " + area);

            if (area < 50)
            {
                Console.WriteLine("Mensagem: Terreno muito pequeno");
            }
            else if (area > 100)
            {
                Console.WriteLine("Mensagem: Terreno muito grande");
            }
           
            Console.ReadKey();
        }
    }
}
