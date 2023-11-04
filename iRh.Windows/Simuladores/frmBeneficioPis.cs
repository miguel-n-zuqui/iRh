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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void rbMaisDeCincoAnos_CheckedChanged(object sender, EventArgs e)
        {
            panelExibirResultadoEButao.Visible = true;
            lblResultadoPis.Visible = false;
            

        }

        private void rbMenosDeCincoAnos_CheckedChanged(object sender, EventArgs e)
        {
            panelExibirResultadoEButao.Visible = true;
            lblResultadoPis.Visible = true;
            lblResultadoPis.Text = "Você não tem direito ao programa PIS";
        }

        private void btnCalcularEVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTempoDeEmpresa.Text))
            {
                MessageBox.Show("VERIFIQUE SE TODAS OS ESCOPOS ESTÃO PREENCHIDOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTempoDeEmpresa.Focus();
                return;
            }
            try
            {
                var tempoDeEmpresa = double.Parse(txtTempoDeEmpresa.Text);
                var salario = double.Parse(txtSalario.Text);
                var valorPis = Pis.Calcular(tempoDeEmpresa,salario);
                lblResultadoPis.Text = (valorPis.ToString("C", CultureInfo.CurrentCulture));
                lblResultadoPis.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("PREENCHA TODOS OS ESCOPOS CORRETAMENTE " + Environment.NewLine + "EX salario: 3500" + Environment.NewLine + " horas mensais: 20 " + Environment.NewLine + "horas noturnas a mais trabalhadas: 2", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTempoDeEmpresa.Focus();
            }
        }
    }
}
