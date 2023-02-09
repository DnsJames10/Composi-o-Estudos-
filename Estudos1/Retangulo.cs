using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

       
        
        public static double Area(double a, double l)
        {

            return a * l;


        }

        public static double Perimetro(double a, double l)
        {
            return a * 2 + l * 2;
        }


    }


}
