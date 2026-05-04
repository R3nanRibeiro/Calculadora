using System;

namespace Calculadora
{
    // Classe responsável por criar e executar a operação correta
    public class Calculadora
    {
        public float Executar(int opcao, float numero1, float numero2)
        {
            // Polimorfismo: a variável é do tipo base "Operacao"
            // mas recebe objetos de tipos diferentes conforme a escolha
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

            // Chama Calcular() — cada classe decide como calcular (polimorfismo)
            return operacao.Calcular();
        }
    }
}