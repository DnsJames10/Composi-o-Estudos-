using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos1
{
    internal class Funcionarios
    {
        private string _nome;
        public int Id { get; set; }
        public double Salario { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }

        public Funcionarios(string nom, int id, double salariofunciona)
        {
            Nome = nom; Id = id; AltSalario(salariofunciona);
        }

        public void AltSalario (double valor)
        {
            if(valor < 100)
            {
                Salario += (Salario * valor) / 100;
            }
            else
            {
                Salario += valor;
            }
        }
    }
}
