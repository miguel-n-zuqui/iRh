using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class AdicionalNoturno
    {
        public static double Calcular(double salario, double horasMensais , double horasNoturnasTrabalhadas)
        {
            var valorHora = salario/horasMensais;
            var valorHoraTrabalhada = valorHora * 0.2 + valorHora;

            return horasNoturnasTrabalhadas * valorHoraTrabalhada + valorHora;
        }
    }
}
