namespace Laboratorio12_2
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
            this.Nota1 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.Label();
            this.Nota3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotaN1 = new System.Windows.Forms.TextBox();
            this.NotaN2 = new System.Windows.Forms.TextBox();
            this.NotaN3 = new System.Windows.Forms.TextBox();
            this.Promedio = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.NotaPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(116, 52);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(42, 13);
            this.Nota1.TabIndex = 0;
            this.Nota1.Text = "Nota 1:";
            this.Nota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(116, 91);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(42, 13);
            this.Nota2.TabIndex = 1;
            this.Nota2.Text = "Nota 2:";
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(116, 131);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(42, 13);
            this.Nota3.TabIndex = 2;
            this.Nota3.Text = "Nota 3:";
            this.Nota3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota Promedio";
            // 
            // NotaN1
            // 
            this.NotaN1.Location = new System.Drawing.Point(178, 49);
            this.NotaN1.Name = "NotaN1";
            this.NotaN1.Size = new System.Drawing.Size(100, 20);
            this.NotaN1.TabIndex = 4;
            this.NotaN1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NotaN2
            // 
            this.NotaN2.Location = new System.Drawing.Point(178, 88);
            this.NotaN2.Name = "NotaN2";
            this.NotaN2.Size = new System.Drawing.Size(100, 20);
            this.NotaN2.TabIndex = 5;
            this.NotaN2.TextChanged += new System.EventHandler(this.NotaN2_TextChanged);
            // 
            // NotaN3
            // 
            this.NotaN3.Location = new System.Drawing.Point(178, 128);
            this.NotaN3.Name = "NotaN3";
            this.NotaN3.Size = new System.Drawing.Size(100, 20);
            this.NotaN3.TabIndex = 6;
            this.NotaN3.TextChanged += new System.EventHandler(this.NotaN3_TextChanged);
            // 
            // Promedio
            // 
            this.Promedio.Location = new System.Drawing.Point(76, 189);
            this.Promedio.Name = "Promedio";
            this.Promedio.Size = new System.Drawing.Size(75, 23);
            this.Promedio.TabIndex = 7;
            this.Promedio.Text = "Promedio";
            this.Promedio.UseVisualStyleBackColor = true;
            this.Promedio.Click += new System.EventHandler(this.Promedio_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(178, 189);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(279, 189);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // NotaPromedio
            // 
            this.NotaPromedio.Location = new System.Drawing.Point(178, 265);
            this.NotaPromedio.Name = "NotaPromedio";
            this.NotaPromedio.Size = new System.Drawing.Size(100, 20);
            this.NotaPromedio.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.NotaPromedio);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Promedio);
            this.Controls.Add(this.NotaN3);
            this.Controls.Add(this.NotaN2);
            this.Controls.Add(this.NotaN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Label Nota2;
        private System.Windows.Forms.Label Nota3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotaN1;
        private System.Windows.Forms.TextBox NotaN2;
        private System.Windows.Forms.TextBox NotaN3;
        private System.Windows.Forms.Button Promedio;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox NotaPromedio;
    }
}

