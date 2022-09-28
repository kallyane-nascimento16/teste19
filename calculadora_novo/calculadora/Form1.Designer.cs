namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonsoma = new System.Windows.Forms.Button();
            this.labelN1 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelRESULTADO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsoma
            // 
            this.buttonsoma.Location = new System.Drawing.Point(368, 208);
            this.buttonsoma.Name = "buttonsoma";
            this.buttonsoma.Size = new System.Drawing.Size(75, 44);
            this.buttonsoma.TabIndex = 0;
            this.buttonsoma.Text = "SOMA ";
            this.buttonsoma.UseVisualStyleBackColor = true;
            this.buttonsoma.Click += new System.EventHandler(this.buttonsoma_Click);
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(67, 90);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(64, 13);
            this.labelN1.TabIndex = 1;
            this.labelN1.Text = "NUMERO 1";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(67, 224);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(61, 13);
            this.labelN2.TabIndex = 2;
            this.labelN2.Text = "NUMERO2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 286);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 39);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 34);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelRESULTADO
            // 
            this.labelRESULTADO.AutoSize = true;
            this.labelRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRESULTADO.Location = new System.Drawing.Point(555, 90);
            this.labelRESULTADO.Name = "labelRESULTADO";
            this.labelRESULTADO.Size = new System.Drawing.Size(124, 24);
            this.labelRESULTADO.TabIndex = 5;
            this.labelRESULTADO.Text = "RESULTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRESULTADO);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.buttonsoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsoma;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelRESULTADO;
        private System.Windows.Forms.Label label2;
    }
}

