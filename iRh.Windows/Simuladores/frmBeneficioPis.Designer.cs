
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.rbMaisDeCincoAnos = new System.Windows.Forms.RadioButton();
            this.lblTempoNoPis = new System.Windows.Forms.Label();
            this.rbMenosDeCincoAnos = new System.Windows.Forms.RadioButton();
            this.panelExibirResultadoEButao = new System.Windows.Forms.Panel();
            this.lblResultadoPis = new System.Windows.Forms.Label();
            this.btnCalcularEVerificar = new System.Windows.Forms.Button();
            this.lblAnosDeEmpresa = new System.Windows.Forms.Label();
            this.txtTempoDeEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panelExibirResultadoEButao.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMaisDeCincoAnos
            // 
            this.rbMaisDeCincoAnos.AutoSize = true;
            this.rbMaisDeCincoAnos.BackColor = System.Drawing.Color.Transparent;
            this.rbMaisDeCincoAnos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaisDeCincoAnos.ForeColor = System.Drawing.Color.White;
            this.rbMaisDeCincoAnos.Location = new System.Drawing.Point(62, 88);
            this.rbMaisDeCincoAnos.Name = "rbMaisDeCincoAnos";
            this.rbMaisDeCincoAnos.Size = new System.Drawing.Size(136, 21);
            this.rbMaisDeCincoAnos.TabIndex = 0;
            this.rbMaisDeCincoAnos.TabStop = true;
            this.rbMaisDeCincoAnos.Text = "MAIS QUE 5 ANOS";
            this.rbMaisDeCincoAnos.UseVisualStyleBackColor = false;
            this.rbMaisDeCincoAnos.CheckedChanged += new System.EventHandler(this.rbMaisDeCincoAnos_CheckedChanged);
            // 
            // lblTempoNoPis
            // 
            this.lblTempoNoPis.AutoSize = true;
            this.lblTempoNoPis.BackColor = System.Drawing.Color.Transparent;
            this.lblTempoNoPis.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoNoPis.ForeColor = System.Drawing.Color.White;
            this.lblTempoNoPis.Location = new System.Drawing.Point(58, 26);
            this.lblTempoNoPis.Name = "lblTempoNoPis";
            this.lblTempoNoPis.Size = new System.Drawing.Size(263, 46);
            this.lblTempoNoPis.TabIndex = 1;
            this.lblTempoNoPis.Text = "QUANTO TEMPO DE CADASTRO \r\nNO PROGRAMA PIS ?";
            // 
            // rbMenosDeCincoAnos
            // 
            this.rbMenosDeCincoAnos.AutoSize = true;
            this.rbMenosDeCincoAnos.BackColor = System.Drawing.Color.Transparent;
            this.rbMenosDeCincoAnos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMenosDeCincoAnos.ForeColor = System.Drawing.Color.White;
            this.rbMenosDeCincoAnos.Location = new System.Drawing.Point(62, 115);
            this.rbMenosDeCincoAnos.Name = "rbMenosDeCincoAnos";
            this.rbMenosDeCincoAnos.Size = new System.Drawing.Size(161, 21);
            this.rbMenosDeCincoAnos.TabIndex = 2;
            this.rbMenosDeCincoAnos.TabStop = true;
            this.rbMenosDeCincoAnos.Text = ">MENOS QUE 5 ANOS";
            this.rbMenosDeCincoAnos.UseVisualStyleBackColor = false;
            this.rbMenosDeCincoAnos.CheckedChanged += new System.EventHandler(this.rbMenosDeCincoAnos_CheckedChanged);
            // 
            // panelExibirResultadoEButao
            // 
            this.panelExibirResultadoEButao.BackColor = System.Drawing.Color.Transparent;
            this.panelExibirResultadoEButao.Controls.Add(this.lblResultadoPis);
            this.panelExibirResultadoEButao.Location = new System.Drawing.Point(12, 272);
            this.panelExibirResultadoEButao.Name = "panelExibirResultadoEButao";
            this.panelExibirResultadoEButao.Size = new System.Drawing.Size(511, 99);
            this.panelExibirResultadoEButao.TabIndex = 3;
            this.panelExibirResultadoEButao.Visible = false;
            // 
            // lblResultadoPis
            // 
            this.lblResultadoPis.AutoSize = true;
            this.lblResultadoPis.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPis.ForeColor = System.Drawing.Color.White;
            this.lblResultadoPis.Location = new System.Drawing.Point(46, 32);
            this.lblResultadoPis.Name = "lblResultadoPis";
            this.lblResultadoPis.Size = new System.Drawing.Size(122, 21);
            this.lblResultadoPis.TabIndex = 0;
            this.lblResultadoPis.Text = "resutlado";
            this.lblResultadoPis.Visible = false;
            // 
            // btnCalcularEVerificar
            // 
            this.btnCalcularEVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularEVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularEVerificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEVerificar.ForeColor = System.Drawing.Color.White;
            this.btnCalcularEVerificar.Location = new System.Drawing.Point(58, 230);
            this.btnCalcularEVerificar.Name = "btnCalcularEVerificar";
            this.btnCalcularEVerificar.Size = new System.Drawing.Size(121, 35);
            this.btnCalcularEVerificar.TabIndex = 1;
            this.btnCalcularEVerificar.Text = "CALCULAR";
            this.btnCalcularEVerificar.UseVisualStyleBackColor = false;
            this.btnCalcularEVerificar.Click += new System.EventHandler(this.btnCalcularEVerificar_Click);
            // 
            // lblAnosDeEmpresa
            // 
            this.lblAnosDeEmpresa.AutoSize = true;
            this.lblAnosDeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblAnosDeEmpresa.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnosDeEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblAnosDeEmpresa.Location = new System.Drawing.Point(350, 26);
            this.lblAnosDeEmpresa.Name = "lblAnosDeEmpresa";
            this.lblAnosDeEmpresa.Size = new System.Drawing.Size(249, 46);
            this.lblAnosDeEmpresa.TabIndex = 4;
            this.lblAnosDeEmpresa.Text = "QUANTOS ANOS DE EMPRESA \r\nVOCÊ TEM  ?";
            // 
            // txtTempoDeEmpresa
            // 
            this.txtTempoDeEmpresa.Location = new System.Drawing.Point(354, 88);
            this.txtTempoDeEmpresa.Name = "txtTempoDeEmpresa";
            this.txtTempoDeEmpresa.Size = new System.Drawing.Size(233, 20);
            this.txtTempoDeEmpresa.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(58, 192);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(233, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(58, 159);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(169, 23);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "DIGITE SEU SALÁRIO";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.iRH_Pis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.btnCalcularEVerificar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtTempoDeEmpresa);
            this.Controls.Add(this.lblAnosDeEmpresa);
            this.Controls.Add(this.panelExibirResultadoEButao);
            this.Controls.Add(this.rbMenosDeCincoAnos);
            this.Controls.Add(this.lblTempoNoPis);
            this.Controls.Add(this.rbMaisDeCincoAnos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panelExibirResultadoEButao.ResumeLayout(false);
            this.panelExibirResultadoEButao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaisDeCincoAnos;
        private System.Windows.Forms.Label lblTempoNoPis;
        private System.Windows.Forms.RadioButton rbMenosDeCincoAnos;
        private System.Windows.Forms.Panel panelExibirResultadoEButao;
        private System.Windows.Forms.Label lblResultadoPis;
        private System.Windows.Forms.Label lblAnosDeEmpresa;
        private System.Windows.Forms.Button btnCalcularEVerificar;
        private System.Windows.Forms.TextBox txtTempoDeEmpresa;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}