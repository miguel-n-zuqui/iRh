using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class Periculosidade
    {
        public static double Calcular(double salario)
        {
            return 0.3 * salario;
        }
    }
}
