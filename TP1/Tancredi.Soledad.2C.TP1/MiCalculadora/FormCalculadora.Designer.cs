namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_Operar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_ConvertiraBin = new System.Windows.Forms.Button();
            this.Btn_ConvertiraDec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // Btn_Operar
            // 
            this.Btn_Operar.Location = new System.Drawing.Point(22, 217);
            this.Btn_Operar.Name = "Btn_Operar";
            this.Btn_Operar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Operar.TabIndex = 1;
            this.Btn_Operar.Text = "Operar";
            this.Btn_Operar.UseVisualStyleBackColor = true;
            this.Btn_Operar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(212, 217);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpiar.TabIndex = 2;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(426, 217);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_ConvertiraBin
            // 
            this.Btn_ConvertiraBin.Location = new System.Drawing.Point(107, 281);
            this.Btn_ConvertiraBin.Name = "Btn_ConvertiraBin";
            this.Btn_ConvertiraBin.Size = new System.Drawing.Size(155, 23);
            this.Btn_ConvertiraBin.TabIndex = 4;
            this.Btn_ConvertiraBin.Text = "Convertir a Binario";
            this.Btn_ConvertiraBin.UseVisualStyleBackColor = true;
            this.Btn_ConvertiraBin.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_ConvertiraDec
            // 
            this.Btn_ConvertiraDec.Location = new System.Drawing.Point(331, 281);
            this.Btn_ConvertiraDec.Name = "Btn_ConvertiraDec";
            this.Btn_ConvertiraDec.Size = new System.Drawing.Size(152, 23);
            this.Btn_ConvertiraDec.TabIndex = 5;
            this.Btn_ConvertiraDec.Text = "Convertir a Decimal";
            this.Btn_ConvertiraDec.UseVisualStyleBackColor = true;
            this.Btn_ConvertiraDec.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(541, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(165, 292);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 329);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_ConvertiraDec);
            this.Controls.Add(this.Btn_ConvertiraBin);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Operar);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Soledad Tancredi del curso 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_Operar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_ConvertiraBin;
        private System.Windows.Forms.Button Btn_ConvertiraDec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
