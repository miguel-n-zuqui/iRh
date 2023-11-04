using iRh.Windows.Cadastros.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmDetalhamento : Form
    {
        public frmDetalhamento()
        {
            InitializeComponent();
        }

        private void btnDetalhamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("INFORME SEU SALÁRIO BASE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salarioBase = double.Parse(txtSalario.Text);
                var cargaHoraria = double.Parse(txtCargaHoraria.Text);
                var horasExtrastrabalhadas = double.Parse(txtHorasTrabalhadas.Text);
                var horasNoturnasTrabalhadas = double.Parse(txtAdicionalNoturno.Text);
                var inss = Inss.Calcular(salarioBase);
                var irrf = Irrf.Calcular(salarioBase);
                var fgts = Fgts.Calcular(salarioBase);
                double periculosidade=0;
                var horaExtra = HoraExtra100.Calcular(salarioBase,cargaHoraria,horasExtrastrabalhadas);
                var adicionalNoturno = AdicionalNoturno.Calcular(salarioBase, cargaHoraria,horasNoturnasTrabalhadas);
                double valeTransporte = 0;
                double descontos = Detalhamento.ResultadosDescontos(salarioBase);
                double adicionais = Detalhamento.ResultadosAdicionais(salarioBase,periculosidade,horaExtra,adicionalNoturno,cargaHoraria);
                double salarioLiquido = Detalhamento.SalarioLiquido(salarioBase, descontos, adicionais);

                if(rbSimPericulosidade.Checked)
                {
                    periculosidade = Periculosidade.Calcular(salarioBase);

                }
                else
                {
                    periculosidade = 0;
                }
                if (rbSimValeTransporte.Checked)
                {
                    valeTransporte = ValeTransporte.Calcular(salarioBase);

                }
                else
                {
                    valeTransporte = 0;
                }
                lblSalarioResposta.Text = "Salario Bruto = " + (salarioBase.ToString("C", CultureInfo.CurrentCulture));
                lblSalarioLiquido.Text = "Salario Liquido = " + (salarioLiquido.ToString("C", CultureInfo.CurrentCulture));
                lblValeTranporteResposta.Text = "Vale transporte = - " +(valeTransporte.ToString("C", CultureInfo.CurrentCulture));
                lblPericulosidadeResposta.Text = "Periculosidade = + " + (periculosidade.ToString("C", CultureInfo.CurrentCulture));
                lblHorasExtrasRespostas.Text = "Hora Extra = + " + (horaExtra.ToString("C", CultureInfo.CurrentCulture));
                lblAdicionalNoturnasResposta.Text = "Adicional Noturno = + " + (adicionalNoturno.ToString("C", CultureInfo.CurrentCulture));
                lblFgts.Text = "FGTS DO MÊS = + " + (fgts.ToString("C", CultureInfo.CurrentCulture));
                lblInssResposta.Text = "INSS = - " + (inss.ToString("C", CultureInfo.CurrentCulture));
                lblIrrfResposta.Text = "IRRF = - " + (irrf.ToString("C", CultureInfo.CurrentCulture));
                lblDescontos.Text = "Total de descontos = - " + (descontos.ToString("C", CultureInfo.CurrentCulture));
                lblAdicionais.Text = "Total de descontos = - " + (adicionais.ToString("C", CultureInfo.CurrentCulture));
                panelResposta.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos dos escopos estão preenchidos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();

            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
