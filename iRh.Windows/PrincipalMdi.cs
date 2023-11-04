using iRh.Windows.Simuladores;
using iRh.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows
{
    public partial class PrincipalMdi : Form
    {
        public PrincipalMdi()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void simuladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDescontoIrrf_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoIrrf();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDescontoInss_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoInss();
            form.MdiParent = this;
            form.Show();

        }

        private void menuBeneficioPericulosidade_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPericulosidade();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioAdicionalNoturno_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioAdicionalNoturno();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioFgts_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFgts();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioFerias_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFerias();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioHorasExtras_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioHoraExtra();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPis_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPis();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioSeguroDesemprego_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioSeguroDesemprego();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioValeTranspote_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioValeTransporte();
            form.MdiParent = this;
            form.Show();
        }

        private void salárioLiquidoNoFinalDoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmDetalhamento();
            form.MdiParent = this;
            form.Show();
        }
    }
}
