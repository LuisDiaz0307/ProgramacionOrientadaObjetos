using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginArreglos
{
    public partial class Form1 : Form
    {
        private bool esta = false;
        private string[,] usuarios =
        {
            {"Luis" , "1234","Diaz" }     ,   //1
            {"Jose" , "2345","Salazar" }     ,   //2
            {"Fernanda" , "3456","Ruiz" }     ,   //3
            {"Mario" , "4567","Duarte" }     ,   //4
            {"Maria" , "5678","Guzman" }     ,   //5
            {"Antonio" , "6789","Olguin" }     , //6
            {"Pepe" , "7891","rico" }     ,   //7
            {"Santiago" , "9123","Rojo" }     ,   //8
            {"Saul" , "1889","Valle" }     ,   //9
            {"Raul" , "1998","Fonseca" }         //10
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            esta = false;
            if (textBox1.Text != "")
            {
                for (int i = 0; i <= usuarios.GetUpperBound(0); i++)
                {


                    if (textBox1.Text == usuarios[i, 0] && textBox2.Text == usuarios[i, 1])
                    {
                        //MessageBox.Show("[" + usuarios[i, 0] + " " + usuarios[i, 2] + ", " + usuarios[i, 1] + "]");

                        this.Hide();
                        new MenuPrincipal().ShowDialog(); //ShowDialog es para 1 pestaña a la vez, show son varias iguales
                        this.Show();
                        esta = true;

                    }
                    /*else 
                    {
                        MessageBox.Show("Usuario no existe");
                    }*/
                }
                if (esta == false)
                {
                    MessageBox.Show("Usuario/Contraseña no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Te hacen falta datos");
            }

        }
    }
}
