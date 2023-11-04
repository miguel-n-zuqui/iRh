
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.lblPerguntaDeDesemprego = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultadoSeguroDesemprego = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.BackColor = System.Drawing.Color.Transparent;
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhados.ForeColor = System.Drawing.Color.White;
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(344, 33);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(298, 46);
            this.lblMesesTrabalhados.TabIndex = 0;
            this.lblMesesTrabalhados.Text = "INFORME A QUANTIDADE DE MESES \r\nTRABALHADOS NOS ÚLTIMOS ANOS";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.BackColor = System.Drawing.Color.Transparent;
            this.rbNao.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.ForeColor = System.Drawing.Color.White;
            this.rbNao.Location = new System.Drawing.Point(165, 86);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(60, 27);
            this.rbNao.TabIndex = 5;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = false;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.BackColor = System.Drawing.Color.Transparent;
            this.rbSim.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.ForeColor = System.Drawing.Color.White;
            this.rbSim.Location = new System.Drawing.Point(93, 86);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(56, 27);
            this.rbSim.TabIndex = 4;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = false;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // lblPerguntaDeDesemprego
            // 
            this.lblPerguntaDeDesemprego.AutoSize = true;
            this.lblPerguntaDeDesemprego.BackColor = System.Drawing.Color.Transparent;
            this.lblPerguntaDeDesemprego.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntaDeDesemprego.ForeColor = System.Drawing.Color.White;
            this.lblPerguntaDeDesemprego.Location = new System.Drawing.Point(70, 33);
            this.lblPerguntaDeDesemprego.Name = "lblPerguntaDeDesemprego";
            this.lblPerguntaDeDesemprego.Size = new System.Drawing.Size(193, 46);
            this.lblPerguntaDeDesemprego.TabIndex = 3;
            this.lblPerguntaDeDesemprego.Text = "ESTÁ EM SITUAÇÃO DE \r\n     DESEMPREGO?";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblResultadoSeguroDesemprego);
            this.panelResultado.Location = new System.Drawing.Point(74, 247);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(247, 100);
            this.panelResultado.TabIndex = 10;
            // 
            // lblResultadoSeguroDesemprego
            // 
            this.lblResultadoSeguroDesemprego.AutoSize = true;
            this.lblResultadoSeguroDesemprego.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSeguroDesemprego.ForeColor = System.Drawing.Color.White;
            this.lblResultadoSeguroDesemprego.Location = new System.Drawing.Point(3, 41);
            this.lblResultadoSeguroDesemprego.Name = "lblResultadoSeguroDesemprego";
            this.lblResultadoSeguroDesemprego.Size = new System.Drawing.Size(112, 19);
            this.lblResultadoSeguroDesemprego.TabIndex = 11;
            this.lblResultadoSeguroDesemprego.Text = "Resultado";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(74, 158);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(121, 39);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(390, 86);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(185, 20);
            this.txtMesesTrabalhados.TabIndex = 1;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.iRH_seguro_desemprego;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.lblMesesTrabalhados);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.lblPerguntaDeDesemprego);
            this.DoubleBuffered = true;
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.Load += new System.EventHandler(this.frmBeneficioSeguroDesemprego_Load);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label lblPerguntaDeDesemprego;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultadoSeguroDesemprego;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Button btnVerificar;
    }
}