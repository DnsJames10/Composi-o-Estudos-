using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos1
{
    internal class Coversor_de_Moedas
    {
        public static double Conversor(double cota, double dollar)
        {
            return cota * dollar  + (cota * dollar * 0.06);
        }
    
        
    }
}
