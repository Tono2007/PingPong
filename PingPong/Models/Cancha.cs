using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Models
{
    public class Cancha
    {
        private int Ancho;
        private int Alto;

        public Marcador marcador;
        private Pelota pelota;
        private Raqueta raquetaIzquierda;
        private Raqueta raquetaDerecha;


        public Cancha(int Ancho, int Alto)
        {
            this.Alto = Alto;
            this.Ancho = Ancho;
            pelota = new Pelota();
            this.raquetaIzquierda = new Raqueta(3);
            this.raquetaDerecha = new Raqueta(this.Alto - 3);
            this.marcador = new Marcador();
        }
        public void Pintar()
        {
            marcador.Pintar();

            raquetaIzquierda.Pintar();
            raquetaDerecha.Pintar();

            this.MoverRaquetas();
            this.ColisionPelotaRaqueta();
            this.MarcarPunto();

            pelota.Mover();

        }
        private void MoverRaquetas()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Z)
                {
                    raquetaIzquierda.MoverAbajo();
                }
                if (tecla.Key == ConsoleKey.A)
                {
                    raquetaIzquierda.MoverArriba();
                }
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    raquetaDerecha.MoverArriba();
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    raquetaDerecha.MoverAbajo();
                }
            }

        }
        private void ColisionPelotaRaqueta()
        {
            if (pelota.posX == 4 && pelota.posY >= raquetaIzquierda.posicion && pelota.posY <= raquetaIzquierda.posicion + 6)
            {
                pelota.IsBallGoingRight = true;
            }
            if (pelota.posX == 96 && pelota.posY >= raquetaDerecha.posicion && pelota.posY <= raquetaDerecha.posicion + 6)
            {
                pelota.IsBallGoingRight = false;
            }
        }
        private void MarcarPunto()
        {
            if (pelota.IsBallGoingRight && pelota.posX >= 99)
            {
                marcador.contadorIzquierda++;
                pelota.PintarEnLadoIzquierdo();
            }
            if (!pelota.IsBallGoingRight && pelota.posX <= 0)
            {
                marcador.contadorDerecha++;
                pelota.PintarEnLadoDerecho();
            }
        }
    }
}
