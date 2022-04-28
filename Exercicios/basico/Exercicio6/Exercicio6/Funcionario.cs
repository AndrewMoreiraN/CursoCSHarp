using System.Globalization;

namespace Exercicio6
{
    internal class Funcionario
    {
        private string _nome;
        private double _salarioBruto;
        private double _imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double SalarioBruto { get; private set; }

        public double Imposto
        {
            get { return _imposto; }
            set { _imposto = value; }
        }

        private double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void SalarioLiquido(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}