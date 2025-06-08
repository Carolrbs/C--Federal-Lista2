using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" VERIFICADOR DE TRIÂNGULO RETÂNGULO ");

            Console.WriteLine("Por favor, digite os três lados do triângulo.");
            Console.WriteLine("Você pode usar números inteiros ou com casas decimais.");

            double ladoA;
            double ladoB;
            double ladoC;

            // Declaração de variaveis - Hipotenusa e os Catetos
            double supostaHipotenusa;
            double cateto1;
            double cateto2;

            //double ehRetangulo; // Variável para verificar se é um triângulo retângulo

            Console.Write("Digite o valor do primeiro lado (A): ");
            ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado (B): ");
            ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado (C): ");
            ladoC = double.Parse(Console.ReadLine());

            //Lógica para Identificar a Hipotenusa e os Catetos
            supostaHipotenusa = Math.Max(ladoA, Math.Max(ladoB, ladoC));

           
            if (supostaHipotenusa == ladoA)
            {
                cateto1 = ladoB;
                cateto2 = ladoC;
            }
            else if (supostaHipotenusa == ladoB)
            {
                cateto1 = ladoA;
                cateto2 = ladoC;
            }
            else // supostaHipotenusa == ladoC pois se n é o a e nem o b é o c
            {
                cateto1 = ladoA;
                cateto2 = ladoB;
            }
            // Aplicar o Teorema de Pitágoras
            double quadradoHipotenusa = Math.Pow(supostaHipotenusa, 2);
            double somaQuadradosCatetos = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);

            // Verificar a Condição e Apresentar o Resultado
            bool ehRetangulo = Math.Abs(quadradoHipotenusa - somaQuadradosCatetos) < 0.0001;

            if (ehRetangulo)
            {
                Console.WriteLine($"Resultados: Lados ({ladoA}, {ladoB}, {ladoC})");
                Console.WriteLine($"Hipotenusa² = {quadradoHipotenusa}");
                Console.WriteLine($"Cateto1² + Cateto2² = {somaQuadradosCatetos}");
                Console.WriteLine(" ESTE É UM TRIÂNGULO RETÂNGULO! ");
;
            }
            else
            {
                Console.WriteLine($"Resultados: Lados ({ladoA}, {ladoB}, {ladoC})");
                Console.WriteLine($"Hipotenusa² = {quadradoHipotenusa}");
                Console.WriteLine($"Cateto1² + Cateto2² = {somaQuadradosCatetos}");

                Console.WriteLine(" ESTE NÃO É UM TRIÂNGULO RETÂNGULO. ");
            }
            //OMG que código dificil, e sim pesquisei o que poderia retornar e usei o boleano se n saberia fazer.
            Console.ReadKey();
        }
    }
}
    


