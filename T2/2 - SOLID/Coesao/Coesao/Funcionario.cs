namespace Coesao
{
    public class Funcionario
    {
        public Cargo cargo { get; private set; }
        public double SalarioBase { get; internal set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.cargo = cargo;
            SalarioBase = salarioBase;
        }
        public double CalculaSalario()
        {
            return this.cargo.Regra.Calcula(this);
        }
    }
}