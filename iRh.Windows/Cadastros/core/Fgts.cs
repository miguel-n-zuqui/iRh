using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class Fgts
    {
        public static double Calcular(double salario)
        {
            double valorFgts;
            valorFgts = salario * 0.08; 
            return valorFgts; 
        }
    }
}
