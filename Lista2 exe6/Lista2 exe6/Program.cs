using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double r;

            Console.WriteLine("Vamos verificar seu peso conforme sua altura.");
            Console.Write("Digite seu peso (kg): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            altura = double.Parse(Console.ReadLine());

            r = peso / (altura * altura);
            if (r < 20)
            {
                Console.WriteLine("Você está com baixo peso.");
            }
            else if (r >= 20 && r < 25)
            {
                Console.WriteLine("Você está com peso ideal.");
            }
            else // r >= 25
            {
                Console.WriteLine("Você está acima do peso.");
            }
            Console.ReadKey();
        }
    }
}
