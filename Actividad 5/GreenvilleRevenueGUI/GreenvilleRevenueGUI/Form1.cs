using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class GreenvilleRevenueGUI : Form
    {
        public GreenvilleRevenueGUI()
        {
            InitializeComponent();
        }

        private void GreenvilleRevenueGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pasado = float.Parse(textBox1.Text);
            float presente = float.Parse(textBox2.Text);
            double doble = (pasado * 2);

            if (presente >= doble)
            {
                textBox4.Text = ("The competition is more than twice as big this year!");

            }
            else
            {
                if (presente > pasado)
                {

                    textBox4.Text = ("The competition is bigger than ever!");
                }
                else
                {
                    if (presente < pasado)
                    {
                        textBox4.Text = ("A tighter race this year! Come out and cast your vote!");
                    }
                }
            }


        }
            }




        }

