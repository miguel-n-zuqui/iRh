
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResutadoAdicionalNoturno = new System.Windows.Forms.Label();
            this.btnHorasExtra100 = new System.Windows.Forms.Button();
            this.txtHorasExtrasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtHorasMensais = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasPorMes = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnHoraExtra50 = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblResutadoAdicionalNoturno);
            this.panelResultado.Location = new System.Drawing.Point(252, 192);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(175, 100);
            this.panelResultado.TabIndex = 18;
            this.panelResultado.Visible = false;
            // 
            // lblResutadoAdicionalNoturno
            // 
            this.lblResutadoAdicionalNoturno.AutoSize = true;
            this.lblResutadoAdicionalNoturno.BackColor = System.Drawing.Color.Transparent;
            this.lblResutadoAdicionalNoturno.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F);
            this.lblResutadoAdicionalNoturno.ForeColor = System.Drawing.Color.White;
            this.lblResutadoAdicionalNoturno.Location = new System.Drawing.Point(24, 39);
            this.lblResutadoAdicionalNoturno.Name = "lblResutadoAdicionalNoturno";
            this.lblResutadoAdicionalNoturno.Size = new System.Drawing.Size(133, 24);
            this.lblResutadoAdicionalNoturno.TabIndex = 8;
            this.lblResutadoAdicionalNoturno.Text = "resultado";
            // 
            // btnHorasExtra100
            // 
            this.btnHorasExtra100.BackColor = System.Drawing.Color.Transparent;
            this.btnHorasExtra100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorasExtra100.ForeColor = System.Drawing.Color.White;
            this.btnHorasExtra100.Location = new System.Drawing.Point(30, 173);
            this.btnHorasExtra100.Name = "btnHorasExtra100";
            this.btnHorasExtra100.Size = new System.Drawing.Size(182, 60);
            this.btnHorasExtra100.TabIndex = 17;
            this.btnHorasExtra100.Text = "CALCULAR HORA EXTRA  100%";
            this.btnHorasExtra100.UseVisualStyleBackColor = false;
            this.btnHorasExtra100.Click += new System.EventHandler(this.btnCalcularHorasExtras_Click);
            // 
            // txtHorasExtrasTrabalhadas
            // 
            this.txtHorasExtrasTrabalhadas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHorasExtrasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtrasTrabalhadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHorasExtrasTrabalhadas.Location = new System.Drawing.Point(276, 84);
            this.txtHorasExtrasTrabalhadas.Name = "txtHorasExtrasTrabalhadas";
            this.txtHorasExtrasTrabalhadas.Size = new System.Drawing.Size(175, 29);
            this.txtHorasExtrasTrabalhadas.TabIndex = 16;
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblHorasNoturnas.ForeColor = System.Drawing.Color.White;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(272, 27);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(168, 46);
            this.lblHorasNoturnas.TabIndex = 15;
            this.lblHorasNoturnas.Text = "QUANTAS HORAS A \r\nMAIS TRABALHOU?";
            // 
            // txtHorasMensais
            // 
            this.txtHorasMensais.BackColor = System.Drawing.Color.White;
            this.txtHorasMensais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHorasMensais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasMensais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHorasMensais.Location = new System.Drawing.Point(510, 84);
            this.txtHorasMensais.Name = "txtHorasMensais";
            this.txtHorasMensais.Size = new System.Drawing.Size(189, 29);
            this.txtHorasMensais.TabIndex = 14;
            // 
            // lblHorasTrabalhadasPorMes
            // 
            this.lblHorasTrabalhadasPorMes.AutoSize = true;
            this.lblHorasTrabalhadasPorMes.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasTrabalhadasPorMes.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblHorasTrabalhadasPorMes.ForeColor = System.Drawing.Color.White;
            this.lblHorasTrabalhadasPorMes.Location = new System.Drawing.Point(506, 27);
            this.lblHorasTrabalhadasPorMes.Name = "lblHorasTrabalhadasPorMes";
            this.lblHorasTrabalhadasPorMes.Size = new System.Drawing.Size(147, 46);
            this.lblHorasTrabalhadasPorMes.TabIndex = 13;
            this.lblHorasTrabalhadasPorMes.Text = "CARGA HORÁRIA \r\nMENSAL";
            // 
            // txtSalario
            // 
            this.txtSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSalario.Location = new System.Drawing.Point(26, 85);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(186, 29);
            this.txtSalario.TabIndex = 12;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(26, 27);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(121, 23);
            this.lblSalario.TabIndex = 11;
            this.lblSalario.Text = "SALÁRIO BASE";
            // 
            // btnHoraExtra50
            // 
            this.btnHoraExtra50.BackColor = System.Drawing.Color.Transparent;
            this.btnHoraExtra50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoraExtra50.ForeColor = System.Drawing.Color.White;
            this.btnHoraExtra50.Location = new System.Drawing.Point(30, 267);
            this.btnHoraExtra50.Name = "btnHoraExtra50";
            this.btnHoraExtra50.Size = new System.Drawing.Size(182, 60);
            this.btnHoraExtra50.TabIndex = 19;
            this.btnHoraExtra50.Text = "CALCULAR HORA EXTRA 50% ";
            this.btnHoraExtra50.UseVisualStyleBackColor = false;
            this.btnHoraExtra50.Click += new System.EventHandler(this.btnHoraExtra50_Click);
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.iRH_Hora_extra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.btnHoraExtra50);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnHorasExtra100);
            this.Controls.Add(this.txtHorasExtrasTrabalhadas);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.txtHorasMensais);
            this.Controls.Add(this.lblHorasTrabalhadasPorMes);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "frmBeneficioHoraExtra";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResutadoAdicionalNoturno;
        private System.Windows.Forms.Button btnHorasExtra100;
        private System.Windows.Forms.TextBox txtHorasExtrasTrabalhadas;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.TextBox txtHorasMensais;
        private System.Windows.Forms.Label lblHorasTrabalhadasPorMes;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnHoraExtra50;
    }
}