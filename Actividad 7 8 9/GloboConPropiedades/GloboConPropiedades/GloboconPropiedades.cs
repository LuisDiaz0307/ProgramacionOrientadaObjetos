using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GloboConPropiedades
{
    class GloboConPropiedades
    {
        public int x = 0;
        public int y = 0;
        public int diametro = 0;


        public void MoverDerecha(int xpasos)
        {
            x = x + xpasos;
        }

        public void MoverArriba(int ypasos)
        {
            y = y + ypasos;
        }

        public void CambiarDiametro(int cambio)
        {
            diametro = cambio;
        }


        public void CambiarTamaño(int cambio)
        {
            diametro = diametro + cambio;
        }

        public void Mostrar(Graphics AreaDibujo)
        {
            Pen pen = new Pen(Color.Black);
            AreaDibujo.DrawEllipse(pen, x, y, diametro, diametro);
        }
        public int coordX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

            public int coordY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
