namespace Laboratorio12
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
            this.VelocidadMovil = new System.Windows.Forms.TextBox();
            this.TiempoMovilUsado = new System.Windows.Forms.TextBox();
            this.TextBoxResultado = new System.Windows.Forms.TextBox();
            this.VelocidadDelMovil = new System.Windows.Forms.Label();
            this.TiempoUsado = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCompilacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular distancia recorrida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VelocidadMovil
            // 
            this.VelocidadMovil.Location = new System.Drawing.Point(219, 58);
            this.VelocidadMovil.Name = "VelocidadMovil";
            this.VelocidadMovil.Size = new System.Drawing.Size(100, 20);
            this.VelocidadMovil.TabIndex = 1;
            this.VelocidadMovil.TextChanged += new System.EventHandler(this.VelocidadMovil_TextChanged);
            // 
            // TiempoMovilUsado
            // 
            this.TiempoMovilUsado.Location = new System.Drawing.Point(219, 106);
            this.TiempoMovilUsado.Name = "TiempoMovilUsado";
            this.TiempoMovilUsado.Size = new System.Drawing.Size(100, 20);
            this.TiempoMovilUsado.TabIndex = 2;
            this.TiempoMovilUsado.TextChanged += new System.EventHandler(this.TiempoMovilUsado_TextChanged);
            // 
            // TextBoxResultado
            // 
            this.TextBoxResultado.Location = new System.Drawing.Point(160, 256);
            this.TextBoxResultado.Name = "TextBoxResultado";
            this.TextBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResultado.TabIndex = 3;
            this.TextBoxResultado.TextChanged += new System.EventHandler(this.TextBoxResultado_TextChanged);
            // 
            // VelocidadDelMovil
            // 
            this.VelocidadDelMovil.AutoSize = true;
            this.VelocidadDelMovil.Location = new System.Drawing.Point(62, 61);
            this.VelocidadDelMovil.Name = "VelocidadDelMovil";
            this.VelocidadDelMovil.Size = new System.Drawing.Size(101, 13);
            this.VelocidadDelMovil.TabIndex = 4;
            this.VelocidadDelMovil.Text = "Velocidad del movil:";
            this.VelocidadDelMovil.Click += new System.EventHandler(this.label2_Click);
            // 
            // TiempoUsado
            // 
            this.TiempoUsado.AutoSize = true;
            this.TiempoUsado.Location = new System.Drawing.Point(62, 109);
            this.TiempoUsado.Name = "TiempoUsado";
            this.TiempoUsado.Size = new System.Drawing.Size(133, 13);
            this.TiempoUsado.TabIndex = 5;
            this.TiempoUsado.Text = "Tiempo usado por el movil:";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(68, 259);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(58, 13);
            this.Resultado.TabIndex = 6;
            this.Resultado.Text = "Resultado:";
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(65, 153);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(170, 153);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCompilacion
            // 
            this.BtnCompilacion.Location = new System.Drawing.Point(271, 153);
            this.BtnCompilacion.Name = "BtnCompilacion";
            this.BtnCompilacion.Size = new System.Drawing.Size(75, 23);
            this.BtnCompilacion.TabIndex = 9;
            this.BtnCompilacion.Text = "Cerrar";
            this.BtnCompilacion.UseVisualStyleBackColor = true;
            this.BtnCompilacion.Click += new System.EventHandler(this.BtnCompilacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.BtnCompilacion);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.TiempoUsado);
            this.Controls.Add(this.VelocidadDelMovil);
            this.Controls.Add(this.TextBoxResultado);
            this.Controls.Add(this.TiempoMovilUsado);
            this.Controls.Add(this.VelocidadMovil);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VelocidadMovil;
        private System.Windows.Forms.TextBox TiempoMovilUsado;
        private System.Windows.Forms.TextBox TextBoxResultado;
        private System.Windows.Forms.Label VelocidadDelMovil;
        private System.Windows.Forms.Label TiempoUsado;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCompilacion;
    }
}

