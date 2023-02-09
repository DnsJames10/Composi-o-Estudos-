using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos1
{
    internal class Listas
    {
        private string _nome;
        public int Idade;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 2)
                    _nome = value;
            }
        }
    }
}
