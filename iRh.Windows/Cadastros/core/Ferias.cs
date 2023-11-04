using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class Ferias
    {
        public static double Calcular(double salario)
        {
            var inss = Inss.Calcular(salario);
            var irrf = Irrf.Calcular(salario);
            double valorFerias = 0;
            double tercoFerias = 0;
            double valorBruto = 0;
            const double diasFerias = 30;
            tercoFerias = salario / 3;
            valorBruto = salario + tercoFerias;
            valorFerias = valorBruto - inss - irrf;
            valorFerias = valorFerias - salario;
            return valorFerias;
        }
    }
}
