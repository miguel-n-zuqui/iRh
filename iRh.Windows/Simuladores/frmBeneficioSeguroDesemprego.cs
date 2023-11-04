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
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        private object panelMesesTrabalhados;

        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void frmBeneficioSeguroDesemprego_Load(object sender, EventArgs e)
        {

        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
           
            lblResultadoSeguroDesemprego.Text = " ";

        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            panelResultado.Visible = true;
            lblResultadoSeguroDesemprego.Text = "Você não tem o direito ao seguro desemprego";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Informe quantos meses trabalhou!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMesesTrabalhados.Focus();
                return;
            }


            try
            {
                var meses = int.Parse(txtMesesTrabalhados.Text);
                if (meses >= 12)
                {
                    lblResultadoSeguroDesemprego.Text = "Tem direito ao Seguro-Desemprego";
                    panelResultado.Visible = true;
                }
                else
                {
                    lblResultadoSeguroDesemprego.Text = "Não tem direito ao Seguro-Desemprego";
                    panelResultado.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("informe uma qunatidade de meses Válido, ex 16", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
