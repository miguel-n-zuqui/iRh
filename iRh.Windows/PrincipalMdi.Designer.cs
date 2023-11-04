
namespace iRh.Windows
{
    partial class PrincipalMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdicionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioHorasExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioValeTranspote = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioLiquidoNoFinalDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFuncionario});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(142, 22);
            this.menuCadastroFuncionario.Text = "Funcionarios";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescontoInss,
            this.menuDescontoIrrf,
            this.toolStripSeparator1,
            this.menuBeneficioAdicionalNoturno,
            this.menuBeneficioFgts,
            this.menuBeneficioFerias,
            this.menuBeneficioHorasExtras,
            this.menuBeneficioPericulosidade,
            this.menuBeneficioPis,
            this.menuBeneficioSeguroDesemprego,
            this.menuBeneficioValeTranspote,
            this.salárioLiquidoNoFinalDoMêsToolStripMenuItem});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.simuladoresToolStripMenuItem.Text = " Simuladores";
            this.simuladoresToolStripMenuItem.Click += new System.EventHandler(this.simuladoresToolStripMenuItem_Click);
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(240, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrrf
            // 
            this.menuDescontoIrrf.Name = "menuDescontoIrrf";
            this.menuDescontoIrrf.Size = new System.Drawing.Size(240, 22);
            this.menuDescontoIrrf.Text = "Desconto de IRRF";
            this.menuDescontoIrrf.Click += new System.EventHandler(this.menuDescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // menuBeneficioAdicionalNoturno
            // 
            this.menuBeneficioAdicionalNoturno.Name = "menuBeneficioAdicionalNoturno";
            this.menuBeneficioAdicionalNoturno.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioAdicionalNoturno.Text = "Beneficio de Adicional Noturno";
            this.menuBeneficioAdicionalNoturno.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturno_Click);
            // 
            // menuBeneficioFgts
            // 
            this.menuBeneficioFgts.Name = "menuBeneficioFgts";
            this.menuBeneficioFgts.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioFgts.Text = "Beneficio de Depósito FGTS";
            this.menuBeneficioFgts.Click += new System.EventHandler(this.menuBeneficioFgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioFerias.Text = "Beneneficio de Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.menuBeneficioFerias_Click);
            // 
            // menuBeneficioHorasExtras
            // 
            this.menuBeneficioHorasExtras.Name = "menuBeneficioHorasExtras";
            this.menuBeneficioHorasExtras.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioHorasExtras.Text = "Beneficio de Hora extra";
            this.menuBeneficioHorasExtras.Click += new System.EventHandler(this.menuBeneficioHorasExtras_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioPericulosidade.Text = "Beneficio de Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioPis.Text = "Beneficio de PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioSeguroDesemprego
            // 
            this.menuBeneficioSeguroDesemprego.Name = "menuBeneficioSeguroDesemprego";
            this.menuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioSeguroDesemprego.Text = "Beneficio Seguro Desemprego";
            this.menuBeneficioSeguroDesemprego.Click += new System.EventHandler(this.menuBeneficioSeguroDesemprego_Click);
            // 
            // menuBeneficioValeTranspote
            // 
            this.menuBeneficioValeTranspote.Name = "menuBeneficioValeTranspote";
            this.menuBeneficioValeTranspote.Size = new System.Drawing.Size(240, 22);
            this.menuBeneficioValeTranspote.Text = "Beneficios de Vale Transporte";
            this.menuBeneficioValeTranspote.Click += new System.EventHandler(this.menuBeneficioValeTranspote_Click);
            // 
            // salárioLiquidoNoFinalDoMêsToolStripMenuItem
            // 
            this.salárioLiquidoNoFinalDoMêsToolStripMenuItem.Name = "salárioLiquidoNoFinalDoMêsToolStripMenuItem";
            this.salárioLiquidoNoFinalDoMêsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.salárioLiquidoNoFinalDoMêsToolStripMenuItem.Text = "Salário Liquido no Final do mês";
            this.salárioLiquidoNoFinalDoMêsToolStripMenuItem.Click += new System.EventHandler(this.salárioLiquidoNoFinalDoMêsToolStripMenuItem_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Fundo_tela_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "PrincipalMdi";
            this.Text = "PrincipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioHorasExtras;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioValeTranspote;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem salárioLiquidoNoFinalDoMêsToolStripMenuItem;
    }
}