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
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btnprod = new System.Windows.Forms.Button();
            this.Btncoc = new System.Windows.Forms.Button();
            this.Btnresta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblop1
            // 
            this.Lblop1.AutoSize = true;
            this.Lblop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblop1.Location = new System.Drawing.Point(40, 31);
            this.Lblop1.Name = "Lblop1";
            this.Lblop1.Size = new System.Drawing.Size(96, 18);
            this.Lblop1.TabIndex = 0;
            this.Lblop1.Text = "1er Operador";
            // 
            // Lblop2
            // 
            this.Lblop2.AutoSize = true;
            this.Lblop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblop2.Location = new System.Drawing.Point(40, 69);
            this.Lblop2.Name = "Lblop2";
            this.Lblop2.Size = new System.Drawing.Size(100, 18);
            this.Lblop2.TabIndex = 1;
            this.Lblop2.Text = "2do Operador";
            // 
            // Lbirta
            // 
            this.Lbirta.AutoSize = true;
            this.Lbirta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbirta.Location = new System.Drawing.Point(40, 118);
            this.Lbirta.Name = "Lbirta";
            this.Lbirta.Size = new System.Drawing.Size(75, 18);
            this.Lbirta.TabIndex = 2;
            this.Lbirta.Text = "Resultado";
            // 
            // Txtop1
            // 
            this.Txtop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtop1.Location = new System.Drawing.Point(168, 25);
            this.Txtop1.Name = "Txtop1";
            this.Txtop1.Size = new System.Drawing.Size(100, 24);
            this.Txtop1.TabIndex = 3;
            // 
            // Txtrta
            // 
            this.Txtrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtrta.Location = new System.Drawing.Point(168, 112);
            this.Txtrta.Name = "Txtrta";
            this.Txtrta.Size = new System.Drawing.Size(100, 24);
            this.Txtrta.TabIndex = 4;
            // 
            // Txtop2
            // 
            this.Txtop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtop2.Location = new System.Drawing.Point(168, 63);
            this.Txtop2.Name = "Txtop2";
            this.Txtop2.Size = new System.Drawing.Size(100, 24);
            this.Txtop2.TabIndex = 5;
            // 
            // Btnsuma
            // 
            this.Btnsuma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsuma.Location = new System.Drawing.Point(320, 24);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(86, 32);
            this.Btnsuma.TabIndex = 6;
            this.Btnsuma.Text = "Suma";
            this.Btnsuma.UseVisualStyleBackColor = false;
            this.Btnsuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.Location = new System.Drawing.Point(110, 178);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 7;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            // 
            // Btnprod
            // 
            this.Btnprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnprod.Location = new System.Drawing.Point(320, 154);
            this.Btnprod.Name = "Btnprod";
            this.Btnprod.Size = new System.Drawing.Size(86, 23);
            this.Btnprod.TabIndex = 8;
            this.Btnprod.Text = "Producto";
            this.Btnprod.UseVisualStyleBackColor = true;
            // 
            // Btncoc
            // 
            this.Btncoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncoc.Location = new System.Drawing.Point(320, 111);
            this.Btncoc.Name = "Btncoc";
            this.Btncoc.Size = new System.Drawing.Size(86, 23);
            this.Btncoc.TabIndex = 9;
            this.Btncoc.Text = "Cociente";
            this.Btncoc.UseVisualStyleBackColor = true;
            // 
            // Btnresta
            // 
            this.Btnresta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnresta.Location = new System.Drawing.Point(320, 62);
            this.Btnresta.Name = "Btnresta";
            this.Btnresta.Size = new System.Drawing.Size(86, 23);
            this.Btnresta.TabIndex = 10;
            this.Btnresta.Text = "Resta";
            this.Btnresta.UseVisualStyleBackColor = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(431, 223);
            this.Controls.Add(this.Btnresta);
            this.Controls.Add(this.Btncoc);
            this.Controls.Add(this.Btnprod);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnsuma);
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
        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnprod;
        private System.Windows.Forms.Button Btncoc;
        private System.Windows.Forms.Button Btnresta;
    }
}

