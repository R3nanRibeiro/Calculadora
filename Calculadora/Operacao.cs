namespace Calculadora
{
    public abstract class Operacao
    {
        public float Numero1 { get; set; }
        public float Numero2 { get; set; }

        public Operacao(float numero1, float numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public abstract float Calcular();

        public virtual string Descricao()
        {
            return $"Operação entre {Numero1} e {Numero2}";
        }
    }
}
