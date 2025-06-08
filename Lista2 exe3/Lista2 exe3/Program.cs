using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numero1;
            double numero2;
            double numero3;

            Console.WriteLine("Vamos descobrir o maior entre dois números que você digitar.");

            Console.Write("Digite o PRIMEIRO número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o SEGUNDO número: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o TERCEIRO número: ");
            numero3 = double.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("O PRIMEIRO número é o maior: " + numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("O SEGUNDO número é o maior: " + numero2);
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine("O TERCEIRO número é o maior: " + numero3);
            }
            else
            {
                Console.WriteLine("Há números iguais e maiores entre os valores digitados.");
            }

            Console.ReadKey(); // Espera você apertar uma tecla para a janela não fechar sozinha

        }
    }

}
    
