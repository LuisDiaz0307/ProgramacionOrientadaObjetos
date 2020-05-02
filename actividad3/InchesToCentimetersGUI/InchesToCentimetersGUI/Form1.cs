using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchesToCentimetersGUI
{
    public partial class Form1 : Form
    {
        private const string V = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Pulgadas = float.Parse(this.Valor.Text);
            double centimetros = (Pulgadas * 2.54);
            this.Resultado.Text = centimetros.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            Valor.Text = "";

            Resultado.Text = "";

        }

        private void Valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
