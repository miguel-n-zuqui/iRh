using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class HoraExtra50
    {
        public static double Calcular(double salario, double cargaHorariaMensal, double horaExtraAMais)
        {
            double horaExtra = 0;
            double valorHora = 0;
            valorHora = (salario / cargaHorariaMensal) * 1.5;
            horaExtra = valorHora * horaExtraAMais;
            return horaExtra;
            return 0;
        }
    }
}
