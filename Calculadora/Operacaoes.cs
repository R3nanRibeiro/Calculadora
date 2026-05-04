using System;

namespace Calculadora
{
    public class Adicao : Operacao
    {
        public Adicao(float numero1, float numero2) : base(numero1, numero2) { }

        public override float Calcular() => Numero1 + Numero2;

        public override string Descricao() => $"{Numero1} + {Numero2}";
    }

    public class Subtracao : Operacao
    {
        public Subtracao(float numero1, float numero2) : base(numero1, numero2) { }

        public override float Calcular() => Numero1 - Numero2;

        public override string Descricao() => $"{Numero1} - {Numero2}";
    }

    public class Multiplicacao : Operacao
    {
        public Multiplicacao(float numero1, float numero2) : base(numero1, numero2) { }

        public override float Calcular() => Numero1 * Numero2;

        public override string Descricao() => $"{Numero1} × {Numero2}";
    }

    public class Divisao : Operacao
    {
        public Divisao(float numero1, float numero2) : base(numero1, numero2) { }

        public override float Calcular()
        {
            if (Numero2 == 0)
                throw new DivideByZeroException("Erro: divisão por zero não é permitida.");

            return Numero1 / Numero2;
        }

        public override string Descricao() => $"{Numero1} ÷ {Numero2}";
    }
}