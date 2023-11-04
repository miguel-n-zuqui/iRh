using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class Pis
    {
        public static double Calcular(double anosDeEmpresa,double salario)
        {
            var mesesTrabalhados = anosDeEmpresa * 12;
            double valorDoPis = 0;
            valorDoPis = salario / 12 * mesesTrabalhados;
            return valorDoPis;
        }
    }
}
