namespace Alura.LeilaoOnline.Core
{
    public class Lance
    {
        public Interessada Cliente { get; }
        public double Valor { get; }

        public Lance(Interessada cliente, double valor)
        {
            if (valor < 0)
            {
                throw new System.ArgumentException("Valor do Lance nao pode ser negativo, todo lance deve ser igual ou maior que zero");
            }
            else
            {
                Cliente = cliente;
                Valor = valor;
            }
        }
    }
}
