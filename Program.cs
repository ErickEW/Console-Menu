using System;

namespace console_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            ¡Bienvenido a la nevería!

            1) Tipo de cono
            2) Sabor de nieve
            3) Sencillo o doble
            4) Con o sin chocolate
            5) Toppings

            6) Pagar

            9) Salir

            Selecciona una opción:
            > 1
            [enter]

            */

            Menu menu = new Menu();
            menu.Display();
        }
    }
}

