namespace Acoplamento
{
    public class Fatura
    {
        private int v1;
        private string v2;

        public Fatura(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double ValorMensal { get; internal set; }


    }
}