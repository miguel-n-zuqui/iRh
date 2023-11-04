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
    public partial class frmDescontoIrrf : Form
    {
        private object inss;

        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void btnCalcularIrrf_Click(object sender, EventArgs e)
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
                var descontoIrrf = Irrf.Calcular(salario);
                lblResultadoIrrf.Text = (descontoIrrf.ToString("C", CultureInfo.CurrentCulture));
                lblResultadoIrrf.Visible = true;
                panelIrrf.Visible = true;
                
                
            }
            catch(Exception)
            {
                MessageBox.Show("Informe um valor de salário válido,ex: 3500", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
            }
        }
    }
}
