using System;

namespace Calculadora
{
    public class Calculadora
    {
        public float Executar(int opcao, float numero1, float numero2)
        {
            Operacao operacao;

            switch (opcao)
            {
                case 1:
                    operacao = new Adicao(numero1, numero2);
                    break;
                case 2:
                    operacao = new Subtracao(numero1, numero2);
                    break;
                case 3:
                    operacao = new Multiplicacao(numero1, numero2);
                    break;
                case 4:
                    operacao = new Divisao(numero1, numero2);
                    break;
                default:
                    throw new ArgumentException("Opção inválida.");
            }

            Console.WriteLine($"\nOperação: {operacao.Descricao()}");

            return operacao.Calcular();
        }
    }
}
