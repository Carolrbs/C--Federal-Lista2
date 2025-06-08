using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaP1;
            double notaP2Resultado; 

            Console.WriteLine(" CALCULADORA DE NOTA MÍNIMA NA P2 PARA APROVAÇÃO ");
            Console.WriteLine("Vamos descobrir quanto você precisa tirar na P2 para ser aprovado!");
            Console.WriteLine("Lembre-se: A média de aprovação é 5.0 e P2 tem peso dobrado.");

            Console.Write("Digite a sua nota da P1 (Primeira Prova): ");
            notaP1 = double.Parse(Console.ReadLine());

            // Cálculo da Nota Necessária na P2
            // A fórmula da média é: MEDIA = (P1 + 2 * P2) / 3
            // Então, 5.0 = (P1 + 2 * P2) / 3
            // P2 = ( (5.0 * 3) - P1 ) / 2

            notaP2Resultado = (3.0 * 5.0 - notaP1) / 2.0;

            Console.WriteLine($"\nSua nota da P1 foi: {notaP1:F2}");
            Console.WriteLine($"A média mínima para aprovação é: ");

            if (notaP2Resultado <= 10.0 && notaP2Resultado >= 0.0)
            {
                Console.WriteLine($"Para ser aprovado, você precisa tirar no mínimo: {notaP2Resultado} na P2.");
            }
            else if (notaP2Resultado < 0.0)
            {
                Console.WriteLine("Parabéns! Sua nota da P1 já é tão alta que você precisaria de uma nota negativa na P2 para reprovar!");
                Console.WriteLine("Você já está garantido na aprovação, desde que não zere a P2!");
            }
            else // notaP2Necessaria > 10.0
            {
                Console.WriteLine("Infelizmente, mesmo tirando 10.0 na P2, você não conseguiria atingir a média.");
                Console.WriteLine($"Você precisaria de uma nota de aproximadamente {notaP2Resultado} na P2, o que é acima do máximo permitido.");
                Console.WriteLine("Lamentamos informar que você já está reprovado(a) nesta matéria.");
            }

            // 6. Finalização do Programa
            Console.WriteLine(" Pressione qualquer tecla para sair...");
            Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar
        }
    
    }
}
