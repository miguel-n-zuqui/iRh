
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNoturno));
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtHorasMensais = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasPorMes = new System.Windows.Forms.Label();
            this.txtHorasNorturnasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.lblResutadoAdicionalNoturno = new System.Windows.Forms.Label();
            this.btnCalcularHorasNoturnas = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSalario.Location = new System.Drawing.Point(29, 72);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(306, 35);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(24, 26);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "SALÁRIO BASE";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // txtHorasMensais
            // 
            this.txtHorasMensais.BackColor = System.Drawing.Color.White;
            this.txtHorasMensais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHorasMensais.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasMensais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHorasMensais.Location = new System.Drawing.Point(370, 72);
            this.txtHorasMensais.Name = "txtHorasMensais";
            this.txtHorasMensais.Size = new System.Drawing.Size(227, 35);
            this.txtHorasMensais.TabIndex = 5;
            // 
            // lblHorasTrabalhadasPorMes
            // 
            this.lblHorasTrabalhadasPorMes.AutoSize = true;
            this.lblHorasTrabalhadasPorMes.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasTrabalhadasPorMes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasPorMes.ForeColor = System.Drawing.Color.White;
            this.lblHorasTrabalhadasPorMes.Location = new System.Drawing.Point(365, 30);
            this.lblHorasTrabalhadasPorMes.Name = "lblHorasTrabalhadasPorMes";
            this.lblHorasTrabalhadasPorMes.Size = new System.Drawing.Size(232, 25);
            this.lblHorasTrabalhadasPorMes.TabIndex = 4;
            this.lblHorasTrabalhadasPorMes.Text = "CARGA HORÁRIA MENSAL";
            // 
            // txtHorasNorturnasTrabalhadas
            // 
            this.txtHorasNorturnasTrabalhadas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHorasNorturnasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNorturnasTrabalhadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHorasNorturnasTrabalhadas.Location = new System.Drawing.Point(29, 209);
            this.txtHorasNorturnasTrabalhadas.Name = "txtHorasNorturnasTrabalhadas";
            this.txtHorasNorturnasTrabalhadas.Size = new System.Drawing.Size(306, 35);
            this.txtHorasNorturnasTrabalhadas.TabIndex = 7;
            this.txtHorasNorturnasTrabalhadas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.ForeColor = System.Drawing.Color.White;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(24, 135);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(324, 60);
            this.lblHorasNoturnas.TabIndex = 6;
            this.lblHorasNoturnas.Text = "QUANTAS HORAS NOTURNAS A \r\nMAIS TRABALHOU?";
            // 
            // lblResutadoAdicionalNoturno
            // 
            this.lblResutadoAdicionalNoturno.AutoSize = true;
            this.lblResutadoAdicionalNoturno.BackColor = System.Drawing.Color.Transparent;
            this.lblResutadoAdicionalNoturno.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F);
            this.lblResutadoAdicionalNoturno.ForeColor = System.Drawing.Color.Ivory;
            this.lblResutadoAdicionalNoturno.Location = new System.Drawing.Point(3, 30);
            this.lblResutadoAdicionalNoturno.Name = "lblResutadoAdicionalNoturno";
            this.lblResutadoAdicionalNoturno.Size = new System.Drawing.Size(186, 33);
            this.lblResutadoAdicionalNoturno.TabIndex = 8;
            this.lblResutadoAdicionalNoturno.Text = "resultado";
            // 
            // btnCalcularHorasNoturnas
            // 
            this.btnCalcularHorasNoturnas.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularHorasNoturnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularHorasNoturnas.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCalcularHorasNoturnas.Location = new System.Drawing.Point(29, 292);
            this.btnCalcularHorasNoturnas.Name = "btnCalcularHorasNoturnas";
            this.btnCalcularHorasNoturnas.Size = new System.Drawing.Size(186, 60);
            this.btnCalcularHorasNoturnas.TabIndex = 9;
            this.btnCalcularHorasNoturnas.Text = "CALCULAR ADICIONAL NOTURNO";
            this.btnCalcularHorasNoturnas.UseVisualStyleBackColor = false;
            this.btnCalcularHorasNoturnas.Click += new System.EventHandler(this.btnCalcularHorasNoturnas_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblResutadoAdicionalNoturno);
            this.panelResultado.Location = new System.Drawing.Point(221, 271);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(248, 100);
            this.panelResultado.TabIndex = 10;
            this.panelResultado.Visible = false;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.IRH_ADICIONAL_NOTURNO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcularHorasNoturnas);
            this.Controls.Add(this.txtHorasNorturnasTrabalhadas);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.txtHorasMensais);
            this.Controls.Add(this.lblHorasTrabalhadasPorMes);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.Load += new System.EventHandler(this.frmBeneficioAdicionalNoturno_Load);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtHorasMensais;
        private System.Windows.Forms.Label lblHorasTrabalhadasPorMes;
        private System.Windows.Forms.TextBox txtHorasNorturnasTrabalhadas;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.Label lblResutadoAdicionalNoturno;
        private System.Windows.Forms.Button btnCalcularHorasNoturnas;
        private System.Windows.Forms.Panel panelResultado;
    }
}