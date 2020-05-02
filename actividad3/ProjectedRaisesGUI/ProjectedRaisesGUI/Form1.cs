using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo = double.Parse(this.sueldo.Text);
            double sueldoanual = (sueldo * 1.04);
            this.Nota.Text = "Nota: El Sueldo para Pasando un año de estadia con la compañia incremente 4%, Siendo Este transcurriendo el año: " + sueldoanual.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
