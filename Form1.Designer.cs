namespace CalcularIMCC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcularIMC = new Button();
            label3 = new Label();
            lbIMC = new Label();
            lbClassificacao = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 97);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 151);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(282, 104);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(282, 162);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 3;
            // 
            // btnCalcularIMC
            // 
            btnCalcularIMC.Location = new Point(282, 208);
            btnCalcularIMC.Name = "btnCalcularIMC";
            btnCalcularIMC.Size = new Size(115, 40);
            btnCalcularIMC.TabIndex = 4;
            btnCalcularIMC.Text = "Calcular IMC";
            btnCalcularIMC.UseVisualStyleBackColor = true;
            btnCalcularIMC.Click += btnCalcularIMC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 297);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // lbIMC
            // 
            lbIMC.AutoSize = true;
            lbIMC.Location = new Point(276, 337);
            lbIMC.Name = "lbIMC";
            lbIMC.Size = new Size(29, 15);
            lbIMC.TabIndex = 6;
            lbIMC.Text = "IMC";
            lbIMC.Visible = false;
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Location = new Point(276, 379);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(75, 15);
            lbClassificacao.TabIndex = 7;
            lbClassificacao.Text = "Classificação";
            lbClassificacao.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(539, 225);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(lbClassificacao);
            Controls.Add(lbIMC);
            Controls.Add(label3);
            Controls.Add(btnCalcularIMC);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcularIMC;
        private Label label3;
        private Label lbIMC;
        private Label lbClassificacao;
        private Button btnReset;
    }
}
