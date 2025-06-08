using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;

            Console.WriteLine("Vamos descobrir o maior entre dois números que você digitar.");

            Console.Write("Digite o PRIMEIRO número: ");
            numero1 = double.Parse(Console.ReadLine()); 

            Console.Write("Digite o SEGUNDO número: ");
            numero2 = double.Parse(Console.ReadLine()); 

            if (numero1 > numero2) // Se o primeiro número for MAIOR que o segundo
            {
                Console.WriteLine("O PRIMEIRO número é o maior: " + numero1);
            }
            else if (numero1 < numero2) // Se o primeiro número for MENOR que o segundo
            {
                Console.WriteLine("O SEGUNDO número é o maior: " + numero2);
            }
            else // Se os números forem IGUAIS
            {
                Console.WriteLine("Os números são IGUAIS: " + numero1);
            }

            Console.ReadKey(); // Espera você apertar uma tecla para a janela não fechar sozinha

        }

    }
}

