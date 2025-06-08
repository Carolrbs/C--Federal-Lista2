using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir o maior entre dois números que você digitar.");
            Console.Write("Digite o PRIMEIRO número: ");
            string entrada1 = Console.ReadLine(); // Lê o que o usuário digita como texto
            double numero1 = Convert.ToDouble(entrada1); // Converte o texto para um número (pode ter vírgula)

            Console.Write("Digite o SEGUNDO número: ");
            string entrada2 = Console.ReadLine(); // Lê o que o usuário digita como texto
            double numero2 = Convert.ToDouble(entrada2); // Converte o texto para um número (pode ter vírgula)

            if (numero1 > numero2) // Se o primeiro número for MAIOR que o segundo
            {
                Console.WriteLine("O PRIMEIRO número é o maior: " + numero1);
            }
            else // Se não for igual e o primeiro não for maior, então o segundo deve ser o maior
            {
                Console.WriteLine("O SEGUNDO número é o maior: " + numero2);
            }

            Console.ReadKey(); // Espera você apertar uma tecla para a janela não fechar sozinha


        }
    }
}
