namespace TP_Inicial_Parte_B
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lblop1 = new System.Windows.Forms.Label();
            this.Lblop2 = new System.Windows.Forms.Label();
            this.Lbirta = new System.Windows.Forms.Label();
            this.Txtop1 = new System.Windows.Forms.TextBox();
            this.Txtrta = new System.Windows.Forms.TextBox();
            this.Txtop2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblop1
            // 
            this.Lblop1.AutoSize = true;
            this.Lblop1.Location = new System.Drawing.Point(40, 31);
            this.Lblop1.Name = "Lblop1";
            this.Lblop1.Size = new System.Drawing.Size(87, 16);
            this.Lblop1.TabIndex = 0;
            this.Lblop1.Text = "1er Operador";
            // 
            // Lblop2
            // 
            this.Lblop2.AutoSize = true;
            this.Lblop2.Location = new System.Drawing.Point(40, 69);
            this.Lblop2.Name = "Lblop2";
            this.Lblop2.Size = new System.Drawing.Size(91, 16);
            this.Lblop2.TabIndex = 1;
            this.Lblop2.Text = "2do Operador";
            // 
            // Lbirta
            // 
            this.Lbirta.AutoSize = true;
            this.Lbirta.Location = new System.Drawing.Point(40, 118);
            this.Lbirta.Name = "Lbirta";
            this.Lbirta.Size = new System.Drawing.Size(69, 16);
            this.Lbirta.TabIndex = 2;
            this.Lbirta.Text = "Resultado";
            // 
            // Txtop1
            // 
            this.Txtop1.Location = new System.Drawing.Point(168, 25);
            this.Txtop1.Name = "Txtop1";
            this.Txtop1.Size = new System.Drawing.Size(100, 22);
            this.Txtop1.TabIndex = 3;
            // 
            // Txtrta
            // 
            this.Txtrta.Location = new System.Drawing.Point(168, 112);
            this.Txtrta.Name = "Txtrta";
            this.Txtrta.Size = new System.Drawing.Size(100, 22);
            this.Txtrta.TabIndex = 4;
            // 
            // Txtop2
            // 
            this.Txtop2.Location = new System.Drawing.Point(168, 63);
            this.Txtop2.Name = "Txtop2";
            this.Txtop2.Size = new System.Drawing.Size(100, 22);
            this.Txtop2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Producto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cociente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Resta";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 223);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtop2);
            this.Controls.Add(this.Txtrta);
            this.Controls.Add(this.Txtop1);
            this.Controls.Add(this.Lbirta);
            this.Controls.Add(this.Lblop2);
            this.Controls.Add(this.Lblop1);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblop1;
        private System.Windows.Forms.Label Lblop2;
        private System.Windows.Forms.Label Lbirta;
        private System.Windows.Forms.TextBox Txtop1;
        private System.Windows.Forms.TextBox Txtrta;
        private System.Windows.Forms.TextBox Txtop2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

