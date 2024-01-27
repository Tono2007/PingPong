using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Models
{
    internal class Pelota
    {
        public int posX { get; set; }
        public int posY { get; set; }

        //private Cancha cancha;

        public bool IsBallGoingDown { get; set; }
        public bool IsBallGoingRight { get; set; }

        public Pelota()
        {
            //this.cancha = cancha;

            this.PintarEnLadoIzquierdo();
            var rand = new Random();
            if (rand.Next(2) == 0)
            {
                this.PintarEnLadoDerecho();
            }
        }

        public void Pintar()
        {
            Console.SetCursorPosition(this.posX, this.posY);
            Console.WriteLine("x");
        }
        public void PintarEnLadoIzquierdo()
        {
            this.Borrar();
            this.posX = 10;
            this.posY = 3;
            this.IsBallGoingDown = true;
            this.IsBallGoingRight = true;
            this.Pintar();
        }
        public void PintarEnLadoDerecho()
        {
            this.Borrar();
            this.posX = 90;
            this.posY = 3;
            this.IsBallGoingDown = true;
            this.IsBallGoingRight = false;
            this.Pintar();
        }
        public void Mover()
        {
            this.Borrar();
            this.RebotarEnBorde();

            if (IsBallGoingRight)
            {
                this.posX += 1;
            }
            if (!IsBallGoingRight)
            {
                this.posX -= 1;
            }
            if (IsBallGoingDown)
            {
                this.posY += 1;
            }
            if (!IsBallGoingDown)
            {
                this.posY -= 1;
            }

            this.Pintar();

        }

        private void Borrar()
        {
            Console.SetCursorPosition(this.posX, this.posY);
            Console.WriteLine(" ");
        }
        private void RebotarEnBorde()
        {

            if (this.IsBallGoingDown && this.posY >= 28)
            {
                this.IsBallGoingDown = false;
            }
            if (!this.IsBallGoingDown && this.posY <= 0)
            {
                this.IsBallGoingDown = true;
            }

            if (this.IsBallGoingRight && this.posX >= 99)
            {
                this.IsBallGoingRight = false;
            }
            if (!this.IsBallGoingRight && this.posX <= 0)
            {
                this.IsBallGoingRight = true;
            }
        }

    }
}
