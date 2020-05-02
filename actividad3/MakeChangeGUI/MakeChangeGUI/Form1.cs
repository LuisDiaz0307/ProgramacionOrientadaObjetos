using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeChangeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DarCambio_Click(object sender, EventArgs e)
        {
            double total = double.Parse(this.textBox1.Text);
            double cien = total / 100;
            double cien1 = total % 100;
            double cien2 = (total - cien1);
            double cien3 = (cien2 / 100);
            this.textBox2.Text = (cien3).ToString();
            double cincuenta = cien1 / 50;
            double cincuenta1 = cien1 % 50;
            double cincuenta2 = cien1 - cincuenta1;
            double cincuenta3 = cincuenta2 / 50;
            this.textBox3.Text = (cincuenta3).ToString();
            double veinte = cincuenta1 / 20;
            double veinte1 = cincuenta1 % 20;
            double veinte2 = cincuenta1 - veinte1;
            double veinte3 = veinte2 / 20;
            this.textBox4.Text = veinte3.ToString();
            double Diez = veinte1 / 10;
            double Diez1 = veinte1 % 10;
            double Diez2 = veinte1 - Diez1;
            double Diez3 = Diez2 / 10;
            this.textBox5.Text = Diez3.ToString();
            double cinco = Diez1 / 5;
            double cinco1 = Diez1 % 5;
            double cinco2 = Diez1 - cinco1;
            double cinco3 = cinco2 / 5;
            this.textBox6.Text = cinco3.ToString();
            double uno = cinco1 / 1;
            double uno1 = cinco1 % 1;
            double uno2 = cinco1 - uno1;
            double uno3 = uno2 / 1;
            this.textBox7.Text = uno3.ToString();
            double quarter = uno1 / .25;
            double quarter1 = uno1 % .25;
            double quarter2 = uno1 - quarter1;
            double quarter3 = quarter2 / .25;
            this.textBox8.Text = quarter3.ToString();
            double dime = quarter1 / .10;
            double dime1 = quarter1 % .10;
            double dime2 = quarter1 - dime1;
            double dime3 = dime2 / .10;
            this.textBox9.Text = dime3.ToString();
            double nickel = dime1 / .05;
            double nickel1 = dime1 % .05;
            double nickel2 = dime1 - nickel1;
            double nickel3 = nickel2 / .05;
            this.textBox10.Text = nickel3.ToString();
            double pennies = nickel1 / .01;
            double pennies1 = nickel1 % .01;
            double pennies2 = nickel1 - pennies1;
            double pennies3 = pennies2 / .01;
            this.textBox11.Text = pennies3.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
