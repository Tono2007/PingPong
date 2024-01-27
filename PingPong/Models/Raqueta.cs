using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Models
{
    public class Raqueta
    {
        public int posicion { get; set; }
        private int Xpos;

        public Raqueta(int Xpos)
        {
            this.Xpos = Xpos;
        }

        public void Pintar()
        {
            for (int i = posicion; i < posicion + 6; i++)
            {
                Console.SetCursorPosition(this.Xpos, i);
                Console.WriteLine("|");

            }
        }
        public void MoverArriba()
        {
            if (posicion > 0)
            {
                this.Borrar();
                this.posicion -= 1;
                this.Pintar();
            }
        }
        public void MoverAbajo()
        {
            if (posicion + 6 < 29)
            {
                this.Borrar();
                this.posicion += 1;
                this.Pintar();
            }
        }
        private void Borrar()
        {
            for (int i = posicion; i < posicion + 6; i++)
            {
                Console.SetCursorPosition(this.Xpos, i);
                Console.WriteLine(" ");

            }
        }

    }
}
