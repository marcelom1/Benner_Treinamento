namespace Classes_Abertas_OCP_DIP
{
    public class Compra
    {
        private int v1;
        private string v2;

        public Compra(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double Valor { get; internal set; }
        public string Cidade { get; internal set; }
    }
}