using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class ValeTransporte
    {
        public static string Verificador(double salario, double valesPorDia,double valorDaPassagem)
        {

            const double PorcentagemValeTransporte = 0.06;
            const double QuantidadeDeDiasTrabalhados = 20;
            double gastoMensal;
            double valorValeTransporte;
            valorValeTransporte = salario * PorcentagemValeTransporte;
            gastoMensal = valesPorDia * QuantidadeDeDiasTrabalhados * valorDaPassagem;
            if(gastoMensal > valorValeTransporte)
            {
                return "Vale a pena utilizar o vale transporte";
            }
            else
            {
                return "Não vale a pena utilizar o vale transporte";
            }
        }
        public static double Calcular(double salario)
        {

            const double PorcentagemValeTransporte = 0.06;
            const double QuantidadeDeDiasTrabalhados = 20;
            double gastoMensal;
            double valorValeTransporte;
            valorValeTransporte = salario * PorcentagemValeTransporte;
            return valorValeTransporte;
            
        }
    }
}
