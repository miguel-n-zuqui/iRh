
namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPericulosidade
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
            this.panelInss = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularPericulosidade = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panelInss.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInss
            // 
            this.panelInss.BackColor = System.Drawing.Color.Transparent;
            this.panelInss.Controls.Add(this.lblResultado);
            this.panelInss.Location = new System.Drawing.Point(210, 222);
            this.panelInss.Name = "panelInss";
            this.panelInss.Size = new System.Drawing.Size(306, 100);
            this.panelInss.TabIndex = 7;
            this.panelInss.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F);
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(12, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(219, 33);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "RESULTADO";
            // 
            // btnCalcularPericulosidade
            // 
            this.btnCalcularPericulosidade.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularPericulosidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPericulosidade.ForeColor = System.Drawing.Color.White;
            this.btnCalcularPericulosidade.Location = new System.Drawing.Point(210, 147);
            this.btnCalcularPericulosidade.Name = "btnCalcularPericulosidade";
            this.btnCalcularPericulosidade.Size = new System.Drawing.Size(179, 55);
            this.btnCalcularPericulosidade.TabIndex = 6;
            this.btnCalcularPericulosidade.Text = "CALCULAR PERICULOSIDADE";
            this.btnCalcularPericulosidade.UseVisualStyleBackColor = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(210, 82);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(306, 35);
            this.txtSalario.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(205, 36);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "SALÁRIO BASE";
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.IRH_Periculosidade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.panelInss);
            this.Controls.Add(this.btnCalcularPericulosidade);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "frmBeneficioPericulosidade";
            this.panelInss.ResumeLayout(false);
            this.panelInss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInss;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularPericulosidade;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}