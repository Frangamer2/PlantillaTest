using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiniciarJuego : MonoBehaviour
{
    static void Main(string[] args)
    {
        bool juegoActivo = true;

        while (juegoActivo)
        {
            Console.WriteLine("Juego en curso. Presiona 'r' para reiniciar o 'q' para salir.");

            ConsoleKeyInfo tecla = Console.ReadKey();

            if (tecla.Key == ConsoleKey.R)
            {
                Console.Clear();
                Console.WriteLine("Juego reiniciado.");
            }
            else if (tecla.Key == ConsoleKey.Q)
            {
                juegoActivo = false;
            }
        }

        Console.WriteLine("Juego terminado. Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
