using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros.core
{
    public static class Irrf
    {
        public static double Calcular(double salario)
        {
            const double Faixa1 = 2112.00;
            const double Faixa2 = 2826.65;
            const double Faixa3 = 3751.05;
            const double Faixa4 = 4664.68;
            double descontoIrrf = 0;
            var descontoinss = Inss.Calcular(salario);
            salario = salario - 528.00 - descontoinss;

            if (salario <= Faixa1)
            {
                MessageBox.Show("ISENTO ", "INFORMAÇÃO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (salario <= Faixa2)
            {
                descontoIrrf = salario * 0.075 - 158.40;
            }
            else if (salario <= Faixa3)
            {
                descontoIrrf = salario * 0.15 - 370.40;
            }
            else if (salario <= Faixa4)
            {
                descontoIrrf = salario * 0.225 - 651.73 ;
            }
            else
            {
                descontoIrrf = salario * 0.275 - 884.96;
            }
            

            return descontoIrrf;
        }
    }
}
