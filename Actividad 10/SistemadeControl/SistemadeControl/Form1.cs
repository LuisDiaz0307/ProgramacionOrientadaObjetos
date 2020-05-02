using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Luis" && double.Parse(textBox2.Text) == 1234)
            {
                MessageBox.Show("Bienvenido");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
                if (textBox1.Text == "Fernanda" && double.Parse(textBox2.Text) == 4321)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                if (textBox1.Text == "Mario" && double.Parse(textBox2.Text) == 3214)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                if (textBox1.Text == "Hugo" && double.Parse(textBox2.Text) == 2143)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                if (textBox1.Text == "Jose" && double.Parse(textBox2.Text) == 1432)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                if (textBox1.Text == "Pepe" && double.Parse(textBox2.Text) == 1324)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                if (textBox1.Text == "Gary" && double.Parse(textBox2.Text) == 6789)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                    if (textBox1.Text == "tony" && double.Parse(textBox2.Text) == 8976)
                    {
                        MessageBox.Show("Bienvenido");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        if (textBox1.Text == "Gris" && double.Parse(textBox2.Text) == 2020)
                        {
                            MessageBox.Show("Bienvenido");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            if (textBox1.Text == "Maria" && double.Parse(textBox2.Text) == 1998)
                            {
                                MessageBox.Show("Bienvenido");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }
                    }
                }
            }
        }
    }
}
