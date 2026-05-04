namespace Calculadora
{
    // Classe abstrata: define o "contrato" que toda operação deve seguir
    public abstract class Operacao
    {
        public float Numero1 { get; set; }
        public float Numero2 { get; set; }

        public Operacao(float numero1, float numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        // Método abstrato: cada subclasse é obrigada a implementar
        public abstract float Calcular();

        // Método virtual: pode ser sobrescrito se necessário
        public virtual string Descricao()
        {
            return $"Operação entre {Numero1} e {Numero2}";
        }
    }
}