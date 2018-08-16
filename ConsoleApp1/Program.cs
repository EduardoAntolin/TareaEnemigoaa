using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaVideoJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            CaracteristicasDelEnemigo enemigo = new CaracteristicasDelEnemigo();

            enemigo.PosicionEnXDelEnemigo = "La posicion del enemigio en X es: ";
            enemigo.PosicionEnYDelEnemigo = "La posicion del enemigo en Y es: ";
            enemigo.Moverse = " Se ha movido a: ";
            enemigo.Disparar = " El Enemigo ha disparado. ";
            enemigo.Explotar = " El enemigo exploto, cuidado! ";
            Console.ReadLine();
        }
    }
}
