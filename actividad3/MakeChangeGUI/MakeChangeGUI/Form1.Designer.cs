namespace MakeChangeGUI
{
    partial class Form1
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
            this.monto = new System.Windows.Forms.Label();
            this.cien = new System.Windows.Forms.Label();
            this.cincuenta = new System.Windows.Forms.Label();
            this.veinte = new System.Windows.Forms.Label();
            this.diez = new System.Windows.Forms.Label();
            this.cinco = new System.Windows.Forms.Label();
            this.uno = new System.Windows.Forms.Label();
            this.quarter = new System.Windows.Forms.Label();
            this.dime = new System.Windows.Forms.Label();
            this.nickel = new System.Windows.Forms.Label();
            this.Pennies = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.DarCambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Location = new System.Drawing.Point(30, 33);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(70, 13);
            this.monto.TabIndex = 0;
            this.monto.Text = "Monto Total: ";
            this.monto.Click += new System.EventHandler(this.label1_Click);
            // 
            // cien
            // 
            this.cien.AutoSize = true;
            this.cien.Location = new System.Drawing.Point(30, 81);
            this.cien.Name = "cien";
            this.cien.Size = new System.Drawing.Size(85, 13);
            this.cien.TabIndex = 1;
            this.cien.Text = "Billetes de 100 =";
            this.cien.Click += new System.EventHandler(this.label2_Click);
            // 
            // cincuenta
            // 
            this.cincuenta.AutoSize = true;
            this.cincuenta.Location = new System.Drawing.Point(30, 110);
            this.cincuenta.Name = "cincuenta";
            this.cincuenta.Size = new System.Drawing.Size(82, 13);
            this.cincuenta.TabIndex = 2;
            this.cincuenta.Text = "Billetes de 50 = ";
            // 
            // veinte
            // 
            this.veinte.AutoSize = true;
            this.veinte.Location = new System.Drawing.Point(30, 135);
            this.veinte.Name = "veinte";
            this.veinte.Size = new System.Drawing.Size(82, 13);
            this.veinte.TabIndex = 3;
            this.veinte.Text = "Billetes de 20 = ";
            this.veinte.Click += new System.EventHandler(this.label3_Click);
            // 
            // diez
            // 
            this.diez.AutoSize = true;
            this.diez.Location = new System.Drawing.Point(30, 166);
            this.diez.Name = "diez";
            this.diez.Size = new System.Drawing.Size(82, 13);
            this.diez.TabIndex = 4;
            this.diez.Text = "Billetes de 10 = ";
            this.diez.Click += new System.EventHandler(this.label4_Click);
            // 
            // cinco
            // 
            this.cinco.AutoSize = true;
            this.cinco.Location = new System.Drawing.Point(30, 196);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(76, 13);
            this.cinco.TabIndex = 5;
            this.cinco.Text = "Billetes de 5 = ";
            this.cinco.Click += new System.EventHandler(this.label5_Click);
            // 
            // uno
            // 
            this.uno.AutoSize = true;
            this.uno.Location = new System.Drawing.Point(30, 220);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(76, 13);
            this.uno.TabIndex = 6;
            this.uno.Text = "Billetes de 1 = ";
            this.uno.Click += new System.EventHandler(this.label6_Click);
            // 
            // quarter
            // 
            this.quarter.AutoSize = true;
            this.quarter.Location = new System.Drawing.Point(30, 254);
            this.quarter.Name = "quarter";
            this.quarter.Size = new System.Drawing.Size(91, 13);
            this.quarter.TabIndex = 7;
            this.quarter.Text = "Moneda de .25 = ";
            // 
            // dime
            // 
            this.dime.AutoSize = true;
            this.dime.Location = new System.Drawing.Point(30, 284);
            this.dime.Name = "dime";
            this.dime.Size = new System.Drawing.Size(91, 13);
            this.dime.TabIndex = 8;
            this.dime.Text = "Moneda de .10 = ";
            this.dime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nickel
            // 
            this.nickel.AutoSize = true;
            this.nickel.Location = new System.Drawing.Point(30, 317);
            this.nickel.Name = "nickel";
            this.nickel.Size = new System.Drawing.Size(85, 13);
            this.nickel.TabIndex = 9;
            this.nickel.Text = "Moneda de .5 = ";
            // 
            // Pennies
            // 
            this.Pennies.AutoSize = true;
            this.Pennies.Location = new System.Drawing.Point(30, 348);
            this.Pennies.Name = "Pennies";
            this.Pennies.Size = new System.Drawing.Size(96, 13);
            this.Pennies.TabIndex = 10;
            this.Pennies.Text = "Monedas de .01 = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(147, 193);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(147, 217);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(147, 251);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(147, 281);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(147, 314);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(147, 345);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 21;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // DarCambio
            // 
            this.DarCambio.Location = new System.Drawing.Point(686, 406);
            this.DarCambio.Name = "DarCambio";
            this.DarCambio.Size = new System.Drawing.Size(75, 23);
            this.DarCambio.TabIndex = 22;
            this.DarCambio.Text = "Dar Feria";
            this.DarCambio.UseVisualStyleBackColor = true;
            this.DarCambio.Click += new System.EventHandler(this.DarCambio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DarCambio);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pennies);
            this.Controls.Add(this.nickel);
            this.Controls.Add(this.dime);
            this.Controls.Add(this.quarter);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.diez);
            this.Controls.Add(this.veinte);
            this.Controls.Add(this.cincuenta);
            this.Controls.Add(this.cien);
            this.Controls.Add(this.monto);
            this.Name = "Form1";
            this.Text = "MakeChangeGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Label cien;
        private System.Windows.Forms.Label cincuenta;
        private System.Windows.Forms.Label veinte;
        private System.Windows.Forms.Label diez;
        private System.Windows.Forms.Label cinco;
        private System.Windows.Forms.Label uno;
        private System.Windows.Forms.Label quarter;
        private System.Windows.Forms.Label dime;
        private System.Windows.Forms.Label nickel;
        private System.Windows.Forms.Label Pennies;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button DarCambio;
    }
}

