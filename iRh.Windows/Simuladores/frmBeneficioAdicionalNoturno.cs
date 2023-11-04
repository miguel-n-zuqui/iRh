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
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBeneficioAdicionalNoturno_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnCalcularHorasNoturnas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("VERIFIQUE SE TODAS OS ESCOPOS ESTÃO PREENCHIDOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var horasMensais = double.Parse(txtHorasMensais.Text);
                var horasAdicionais = double.Parse(txtHorasNorturnasTrabalhadas.Text);
                double horasNoturnas = AdicionalNoturno.Calcular(salario, horasMensais, horasAdicionais);
                

                lblResutadoAdicionalNoturno.Text = (horasNoturnas.ToString("C", CultureInfo.CurrentCulture));
                panelResultado.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("PREENCHA TODOS OS ESCOPOS CORRETAMENTE "+Environment.NewLine + "EX salario: 3500" + Environment.NewLine + " horas mensais: 20 " + Environment.NewLine + "horas noturnas a mais trabalhadas: 2", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
            }
        }
    }
}
