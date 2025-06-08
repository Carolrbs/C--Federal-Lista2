using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {   
;
            Console.WriteLine(" CALCULADORA DE MÉDIA SEMESTRAL DE ALUNO ");
            Console.WriteLine("Vamos calcular a média das suas duas avaliações (P1 e P2).");
            Console.WriteLine("Lembre-se: P2 tem peso dobrado na média!");

            double notaP1;
            double notaP2;
            double mediaFinal; 

            Console.Write("Digite a nota da P1 (Primeira Prova): ");
            notaP1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da P2 (Segunda Prova): ");
            notaP2 = double.Parse(Console.ReadLine());

            // Cálculo da Média
            // MEDIA = (P1 + 2 * P2) / 3
            mediaFinal = (notaP1 + (2 * notaP2)) / 3; 

            Console.WriteLine($"Sua média final calculada é: {mediaFinal }");

            //  Verificar a Situação do Aluno (Aprovado ou Reprovado)
            if (mediaFinal >= 5.0)
            {
                // Se a condição (mediaFinal >= 5.0) for VERDADEIRA, o aluno está APROVADO.
                Console.WriteLine(" SITUAÇÃO: ALUNO APROVADO! Parabéns! ");

            }
            else // Se a condição acima for FALSA (ou seja, mediaFinal é menor que 5.0)
            {
                // Se a condição for FALSA, o aluno está REPROVADO.
                Console.WriteLine(" SITUAÇÃO: ALUNO REPROVADO. Estude mais. ");
            }

            Console.WriteLine("Pressione qualquer tecla para sair do programa...");
            Console.ReadKey(); 
        }
    }
}
