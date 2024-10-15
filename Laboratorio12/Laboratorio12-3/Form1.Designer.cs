namespace Laboratorio12_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LadoA = new System.Windows.Forms.TextBox();
            this.LadoB = new System.Windows.Forms.TextBox();
            this.LadoC = new System.Windows.Forms.TextBox();
            this.Semiperimetro = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SemiperimetroResultado = new System.Windows.Forms.TextBox();
            this.AreaResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la longitud del lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la longitud del lado B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la longitud del lado C";
            // 
            // LadoA
            // 
            this.LadoA.Location = new System.Drawing.Point(191, 54);
            this.LadoA.Name = "LadoA";
            this.LadoA.Size = new System.Drawing.Size(100, 20);
            this.LadoA.TabIndex = 3;
            this.LadoA.TextChanged += new System.EventHandler(this.LadoA_TextChanged);
            // 
            // LadoB
            // 
            this.LadoB.Location = new System.Drawing.Point(191, 99);
            this.LadoB.Name = "LadoB";
            this.LadoB.Size = new System.Drawing.Size(100, 20);
            this.LadoB.TabIndex = 4;
            this.LadoB.TextChanged += new System.EventHandler(this.LadoB_TextChanged);
            // 
            // LadoC
            // 
            this.LadoC.Location = new System.Drawing.Point(191, 146);
            this.LadoC.Name = "LadoC";
            this.LadoC.Size = new System.Drawing.Size(100, 20);
            this.LadoC.TabIndex = 5;
            this.LadoC.TextChanged += new System.EventHandler(this.LadoC_TextChanged);
            // 
            // Semiperimetro
            // 
            this.Semiperimetro.Location = new System.Drawing.Point(12, 196);
            this.Semiperimetro.Name = "Semiperimetro";
            this.Semiperimetro.Size = new System.Drawing.Size(86, 23);
            this.Semiperimetro.TabIndex = 6;
            this.Semiperimetro.Text = "Semiperimetro";
            this.Semiperimetro.UseVisualStyleBackColor = true;
            this.Semiperimetro.Click += new System.EventHandler(this.Semiperimetro_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(116, 196);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(75, 23);
            this.Area.TabIndex = 7;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(216, 196);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Salida";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 287);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Area del Triangulo";
            // 
            // SemiperimetroResultado
            // 
            this.SemiperimetroResultado.Location = new System.Drawing.Point(191, 248);
            this.SemiperimetroResultado.Name = "SemiperimetroResultado";
            this.SemiperimetroResultado.Size = new System.Drawing.Size(100, 20);
            this.SemiperimetroResultado.TabIndex = 12;
            this.SemiperimetroResultado.TextChanged += new System.EventHandler(this.SemiperimetroResultado_TextChanged);
            // 
            // AreaResultado
            // 
            this.AreaResultado.Location = new System.Drawing.Point(191, 287);
            this.AreaResultado.Name = "AreaResultado";
            this.AreaResultado.Size = new System.Drawing.Size(100, 20);
            this.AreaResultado.TabIndex = 13;
            this.AreaResultado.TextChanged += new System.EventHandler(this.AreaResultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.AreaResultado);
            this.Controls.Add(this.SemiperimetroResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Semiperimetro);
            this.Controls.Add(this.LadoC);
            this.Controls.Add(this.LadoB);
            this.Controls.Add(this.LadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LadoA;
        private System.Windows.Forms.TextBox LadoB;
        private System.Windows.Forms.TextBox LadoC;
        private System.Windows.Forms.Button Semiperimetro;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SemiperimetroResultado;
        private System.Windows.Forms.TextBox AreaResultado;
    }
}

