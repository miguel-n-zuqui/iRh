
namespace iRh.Windows.Simuladores
{
    partial class frmDescontoInss
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
            this.btnCalcularInss = new System.Windows.Forms.Button();
            this.panelInss = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelInss.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(289, 28);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALÁRIO BASE";
            this.lblSalario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(218, 76);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(306, 35);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalcularInss
            // 
            this.btnCalcularInss.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularInss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularInss.ForeColor = System.Drawing.Color.White;
            this.btnCalcularInss.Location = new System.Drawing.Point(266, 138);
            this.btnCalcularInss.Name = "btnCalcularInss";
            this.btnCalcularInss.Size = new System.Drawing.Size(214, 35);
            this.btnCalcularInss.TabIndex = 2;
            this.btnCalcularInss.Text = "CALCULAR INSS";
            this.btnCalcularInss.UseVisualStyleBackColor = false;
            this.btnCalcularInss.Click += new System.EventHandler(this.btnCalcularInss_Click);
            // 
            // panelInss
            // 
            this.panelInss.BackColor = System.Drawing.Color.Transparent;
            this.panelInss.Controls.Add(this.lblResultado);
            this.panelInss.Location = new System.Drawing.Point(218, 216);
            this.panelInss.Name = "panelInss";
            this.panelInss.Size = new System.Drawing.Size(306, 100);
            this.panelInss.TabIndex = 3;
            this.panelInss.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(57, 26);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(192, 33);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "REsultado";
            this.lblResultado.Visible = false;
            // 
            // frmDescontoInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.iRH_Inss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.panelInss);
            this.Controls.Add(this.btnCalcularInss);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDescontoInss";
            this.Text = "Desconto Inss";
            this.Load += new System.EventHandler(this.frmDescontoInss_Load);
            this.panelInss.ResumeLayout(false);
            this.panelInss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcularInss;
        private System.Windows.Forms.Panel panelInss;
        private System.Windows.Forms.Label lblResultado;
    }
}