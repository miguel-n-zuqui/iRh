using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class Inss
    {
        //funcao retorno nome (parametros
        const double Faixa01 = 1320.0;
        const double Faixa02 = 2571.30;
        const double Faixa03 = 3856.95;
        const double Faixa04 = 7507.49;
        public static double Calcular(double salario)
        {
            double valorInss = 0.0 ;
            if(salario<=Faixa01)
            {
                valorInss =CalcularFaixa1(salario);
            }
            else if (salario<=Faixa02)
            {
                var descontoFaixa1 = CalcularFaixa1(salario);
                valorInss = (salario - Faixa01) + descontoFaixa1;
            }
            else if(salario<= Faixa03)
            {
                var descontoFaixa1 = CalcularFaixa1(salario);
                var descontoFaixa2 = CalcularFaixa2(salario);
                valorInss = 12/100 * (salario - Faixa02) + descontoFaixa1 + descontoFaixa2;
            }
            else if (salario<= Faixa04)
            {
                var descontoFaixa1 =CalcularFaixa1(salario);
                var descontoFaixa2 = CalcularFaixa2(salario);
                var descontoFaixa3 = 0.12 * (salario - Faixa02);
                valorInss = 0.14 * (salario - Faixa03) + descontoFaixa1+ descontoFaixa2+ descontoFaixa3;

            }
            else
            {
                var descontoFaixa1 = CalcularFaixa1(salario);
                var descontoFaixa2 = CalcularFaixa2(salario);
                var descontoFaixa3 = CalcularFaixa3(salario);
                valorInss = 0.14 * (Faixa04 - Faixa03) + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;

            }
            return valorInss;
        }
        private static double CalcularFaixa1(double salario)
        {
            return   (0.075 * Faixa01);
        }
        private static double CalcularFaixa2(double salario)
        {
            return 0.09 * (Faixa02 - Faixa01);
        }
        private static double CalcularFaixa3(double salario)
        {
            return 0.12 * (Faixa03 - Faixa02);
        }


    }
}
