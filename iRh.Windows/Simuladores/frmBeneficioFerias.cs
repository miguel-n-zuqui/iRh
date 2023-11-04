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
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalcularFerias_Click(object sender, EventArgs e)
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
                var valorFerias = Ferias.Calcular(salario);
                lblResultado.Text = (valorFerias.ToString("C", CultureInfo.CurrentCulture));
                panelResultado.Visible = true;
                lblResultado.Visible = true;
                
            }
            catch (Exception)
            {
                MessageBox.Show("PREENCHA TODOS OS ESCOPOS CORRETAMENTE " + Environment.NewLine + "EX salario: 3500" + Environment.NewLine + " horas mensais: 20 " + Environment.NewLine + "horas noturnas a mais trabalhadas: 2", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
            }
        }
    }
}
