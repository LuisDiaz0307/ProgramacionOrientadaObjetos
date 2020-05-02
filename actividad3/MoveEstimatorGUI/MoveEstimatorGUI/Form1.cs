using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double millas = double.Parse(this.millas.Text);
            double horas = double.Parse(this.horas.Text);
            double total = (millas * 2) + (horas * 150) + 200;
            this.total.Text = total.ToString();
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
