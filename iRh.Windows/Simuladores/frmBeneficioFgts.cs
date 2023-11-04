using iRh.Windows.Cadastros.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
        {
            InitializeComponent();
        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularFgts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("INFORME SEU SALÁRIO BASE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var descontoFgts = Fgts.Calcular(salario);
                lblResultado.Text = descontoFgts.ToString();
                panelInss.Visible = true;
                panelInss.Visible = true;
                lblResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido,ex: 3500", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();

            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelInss_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
