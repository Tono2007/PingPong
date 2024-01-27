using PingPong.Models;


Console.Clear();
Console.CursorVisible = false;

Cancha cancha = new Cancha(100, 29); 

while (cancha.marcador.contadorIzquierda < 10 && cancha.marcador.contadorDerecha < 10)
{
    cancha.Pintar();
    Thread.Sleep(100);
}

if (cancha.marcador.contadorDerecha == 10)
{
    Console.WriteLine("Right player won!");
}
else
{
    Console.WriteLine("Left player won!");
}
