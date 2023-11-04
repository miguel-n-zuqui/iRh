using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Cadastros.core
{
    public static class Detalhamento
    {
        public static double ResultadosAdicionais(double salarioBase, double periculosidadeResposta, double horaExtrasMais, double adicionalNorturno, double cargaHoraria)
        {
            var fgts = Fgts.Calcular(salarioBase);
           
          
          
            var totalDeAdicionais = fgts + periculosidadeResposta + horaExtrasMais  + adicionalNorturno;
            return totalDeAdicionais;
        }
        public static double ResultadosDescontos(double salarioBase)
        {
            var inss = Inss.Calcular(salarioBase);
            var irrf = Irrf.Calcular(salarioBase);
            var valeTransporte = ValeTransporte.Calcular(salarioBase);
            var totalDeDescontos = inss + irrf + valeTransporte;

            return totalDeDescontos;
        }
        public static double SalarioLiquido(double salarioBase , double resultadoDeDescontos, double resultadoDeAdicionais)
        {
            return salarioBase + resultadoDeAdicionais - resultadoDeDescontos;
        }
    }
}
