
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtValesPorDia = new System.Windows.Forms.TextBox();
            this.lblValesPorDia = new System.Windows.Forms.Label();
            this.txtValorDaPassagem = new System.Windows.Forms.TextBox();
            this.lblValorPassagem = new System.Windows.Forms.Label();
            this.bntVerificador = new System.Windows.Forms.Button();
            this.lblVerificador = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(37, 16);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(157, 25);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Digite seu salário";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSalario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(55, 78);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(120, 20);
            this.txtSalario.TabIndex = 9;
            this.txtSalario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValesPorDia
            // 
            this.txtValesPorDia.Location = new System.Drawing.Point(516, 78);
            this.txtValesPorDia.Name = "txtValesPorDia";
            this.txtValesPorDia.Size = new System.Drawing.Size(120, 20);
            this.txtValesPorDia.TabIndex = 11;
            // 
            // lblValesPorDia
            // 
            this.lblValesPorDia.AutoSize = true;
            this.lblValesPorDia.BackColor = System.Drawing.Color.Transparent;
            this.lblValesPorDia.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblValesPorDia.ForeColor = System.Drawing.Color.White;
            this.lblValesPorDia.Location = new System.Drawing.Point(478, 16);
            this.lblValesPorDia.Name = "lblValesPorDia";
            this.lblValesPorDia.Size = new System.Drawing.Size(189, 50);
            this.lblValesPorDia.TabIndex = 10;
            this.lblValesPorDia.Text = "Quantidade de vales \r\nutilizados por dia:";
            this.lblValesPorDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValorDaPassagem
            // 
            this.txtValorDaPassagem.Location = new System.Drawing.Point(285, 78);
            this.txtValorDaPassagem.Name = "txtValorDaPassagem";
            this.txtValorDaPassagem.Size = new System.Drawing.Size(120, 20);
            this.txtValorDaPassagem.TabIndex = 13;
            this.txtValorDaPassagem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblValorPassagem
            // 
            this.lblValorPassagem.AutoSize = true;
            this.lblValorPassagem.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPassagem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblValorPassagem.ForeColor = System.Drawing.Color.White;
            this.lblValorPassagem.Location = new System.Drawing.Point(259, 16);
            this.lblValorPassagem.Name = "lblValorPassagem";
            this.lblValorPassagem.Size = new System.Drawing.Size(171, 25);
            this.lblValorPassagem.TabIndex = 12;
            this.lblValorPassagem.Text = "Valor da passagem";
            this.lblValorPassagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblValorPassagem.Click += new System.EventHandler(this.label3_Click);
            // 
            // bntVerificador
            // 
            this.bntVerificador.BackColor = System.Drawing.Color.Transparent;
            this.bntVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntVerificador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVerificador.ForeColor = System.Drawing.Color.White;
            this.bntVerificador.Location = new System.Drawing.Point(285, 181);
            this.bntVerificador.Name = "bntVerificador";
            this.bntVerificador.Size = new System.Drawing.Size(120, 38);
            this.bntVerificador.TabIndex = 15;
            this.bntVerificador.Text = "Verificar ";
            this.bntVerificador.UseVisualStyleBackColor = false;
            this.bntVerificador.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblVerificador
            // 
            this.lblVerificador.AutoSize = true;
            this.lblVerificador.BackColor = System.Drawing.Color.Transparent;
            this.lblVerificador.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblVerificador.ForeColor = System.Drawing.Color.White;
            this.lblVerificador.Location = new System.Drawing.Point(218, 115);
            this.lblVerificador.Name = "lblVerificador";
            this.lblVerificador.Size = new System.Drawing.Size(269, 50);
            this.lblVerificador.TabIndex = 16;
            this.lblVerificador.Text = "Verificar se vale apena utilizar \r\no vale transporte:";
            this.lblVerificador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVerificador.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.ForeColor = System.Drawing.Color.White;
            this.panelResultado.Location = new System.Drawing.Point(77, 225);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(509, 100);
            this.panelResultado.TabIndex = 17;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 37);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(105, 26);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.iRH_vale_transporte;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.lblVerificador);
            this.Controls.Add(this.bntVerificador);
            this.Controls.Add(this.txtValorDaPassagem);
            this.Controls.Add(this.lblValorPassagem);
            this.Controls.Add(this.txtValesPorDia);
            this.Controls.Add(this.lblValesPorDia);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "frmBeneficioValeTransporte";
            this.Load += new System.EventHandler(this.frmBeneficioValeTransporte_Load);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtValesPorDia;
        private System.Windows.Forms.Label lblValesPorDia;
        private System.Windows.Forms.TextBox txtValorDaPassagem;
        private System.Windows.Forms.Label lblValorPassagem;
        private System.Windows.Forms.Button bntVerificador;
        private System.Windows.Forms.Label lblVerificador;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}