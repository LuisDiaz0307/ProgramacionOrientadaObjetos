using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloboConPropiedades
{
    public partial class Form1 : Form

    {
        private readonly GloboConPropiedades globo;
        private readonly Graphics AreaDibujo;

        GloboConPropiedades globoConPropiedades;

        GloboConPropiedades globoCon = new GloboConPropiedades();
    
        public Form1()
        {
            InitializeComponent();

            globo = new GloboConPropiedades();

            AreaDibujo = pictureBox1.CreateGraphics();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "X = " + globoCon.x;
            label2.Text = "Y = " + globoCon.y;
            label3.Text = "(0 , 0)";
            label4.Text = "(" + pictureBox1.Width + ", 0)";
            label5.Text = "( 0 , " + pictureBox1.Width + " )";
            label6.Text = "( " + pictureBox1.Width + " , " + pictureBox1.Height + " )";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            globo.CambiarTamaño(int.Parse(textBox5.Text));
            AreaDibujo.Clear(Color.White);
            globo.Mostrar(AreaDibujo);
            label10.Text = "Diametro:  = " + Convert.ToString(globo.diametro) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            globo.coordX = Convert.ToInt32(textBox1.Text);
            AreaDibujo.Clear(Color.White);
            globo.Mostrar(AreaDibujo);
            label1.Text = "X = " + Convert.ToString(globo.coordX);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            globo.coordY = Convert.ToInt32(textBox2.Text);
            AreaDibujo.Clear(Color.White);
            globo.Mostrar(AreaDibujo);
            label2.Text = "Y = " + Convert.ToString(globo.coordY);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            globo.coordX = globo.coordX + int.Parse(textBox3.Text);
            AreaDibujo.Clear(Color.White);
            globo.Mostrar(AreaDibujo);
            label1.Text = "X = " + Convert.ToString(globo.coordX);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            globo.coordY = globo.coordY + int.Parse(textBox4.Text);
            AreaDibujo.Clear(Color.White);
            globo.Mostrar(AreaDibujo);
            label2.Text = "Y = " + Convert.ToString(globo.coordY);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(globo.diametro);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            globo.CambiarDiametro(trackBar1.Value);
            AreaDibujo.Clear(Color.White);
            globo.Mostrar(AreaDibujo);
            label10.Text = "Diametro:  = " + Convert.ToString(globo.diametro) ;

        }
    }

}
