using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());

            try
            {
                var calculadora = new Calculadora();
                float resultado = calculadora.Executar(operacao, num1, num2);

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
