namespace CalculadoraAcuidadeVisual
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.lblErroDistancia = new System.Windows.Forms.Label();
            this.lblErroTamanho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(270, 30);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Acuidade Visual";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distância ao Objeto (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamanho do Objeto (mm)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(50, 30);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(50, 136);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtTamanho.TabIndex = 4;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(267, 155);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(0, 13);
            this.lblAngulo.TabIndex = 5;
            this.lblAngulo.UseWaitCursor = true;
            // 
            // lblErroDistancia
            // 
            this.lblErroDistancia.AutoSize = true;
            this.lblErroDistancia.Location = new System.Drawing.Point(194, 36);
            this.lblErroDistancia.Name = "lblErroDistancia";
            this.lblErroDistancia.Size = new System.Drawing.Size(0, 13);
            this.lblErroDistancia.TabIndex = 6;
            // 
            // lblErroTamanho
            // 
            this.lblErroTamanho.AutoSize = true;
            this.lblErroTamanho.Location = new System.Drawing.Point(197, 142);
            this.lblErroTamanho.Name = "lblErroTamanho";
            this.lblErroTamanho.Size = new System.Drawing.Size(0, 13);
            this.lblErroTamanho.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 236);
            this.Controls.Add(this.lblErroTamanho);
            this.Controls.Add(this.lblErroDistancia);
            this.Controls.Add(this.lblAngulo);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.Label lblErroDistancia;
        private System.Windows.Forms.Label lblErroTamanho;
    }
}

