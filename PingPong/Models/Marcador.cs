using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Models
{
    public class Marcador
    {
        public int contadorIzquierda { get; set; }
        public int contadorDerecha { get; set; }

        public Marcador()
        {
            this.contadorIzquierda = 0;
            this.contadorDerecha = 0;
        }

        public void Pintar()
        {
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(contadorIzquierda);
            Console.SetCursorPosition(95, 2);
            Console.WriteLine(contadorDerecha);
        }
    }
}
