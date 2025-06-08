using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double sexoNumero;



            Console.WriteLine(" CALCULADORA DE ÍNDICE DE MASSA CORPORAL (IMC) ");

            Console.Write("Por favor, digite o seu peso em quilogramas (kg) (ex: 65.5): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Agora, digite a sua altura em metros (m) (ex: 1.75): ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Por fim, digite o seu sexo (1 para Feminino, 2 para Masculino): ");
            sexoNumero = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Cálculo do IMC (Índice de Massa Corporal)
            double alturaAoQuadrado = altura * altura;
            double imc = peso / alturaAoQuadrado;

            Console.WriteLine($"Seu IMC calculado é: ");

            //  Categoria do IMC com base no Sexo Numérico 1 ouu 2
            Console.WriteLine("Sua categoria de peso é:");

            // se o sexo é Feminino (representado por 1)
            if (sexoNumero == 1.0)
            {
                // ategorias específicas para mulheres
                if (imc < 19.0) // Se o IMC for menor que 19
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc <= 19.0 && imc < 24.0)
                {
                    Console.WriteLine("Peso ideal");
                }
                else if (imc >= 24.0)
                {
                    Console.WriteLine("Acima do peso");

                }
                // se o sexo é Masculino (representado por 2)
                else if (sexoNumero == 2.0)
                {
                    if (imc < 20.0)
                    {
                        Console.WriteLine("Abaixo do peso");
                    }
                    else if (imc <= 20.0 && imc < 25.0)
                    {
                        Console.WriteLine("Peso ideal");
                    }
                    else if (imc >= 25.0)
                    {
                        Console.WriteLine("Acima do peso");
                    }
                    // Se o número digitado não for 1 nem 2
                    else
                    {
                        Console.WriteLine("Opção de sexo não reconhecida. Por favor, digite 1 ou 2.");
                    }

                    Console.WriteLine();
                    Console.WriteLine(" Pressione qualquer tecla para sair...");
                    Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o console
                }
            }
        }
    }
}