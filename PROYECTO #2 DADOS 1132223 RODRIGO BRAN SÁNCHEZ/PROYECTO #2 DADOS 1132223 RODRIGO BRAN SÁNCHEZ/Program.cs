using System;

internal class Program
{
    static void Main(string[] args)
    {
        int partidas = 0, tiros = 0;
        bool valpartidas = true, valtiros = true;
        Console.WriteLine("Ingrese la cantidad de partidas que desea jugar");
        do
        {
            valpartidas = int.TryParse(Console.ReadLine(), out partidas);
            if (!valpartidas || partidas <= 0)
            {
                Console.WriteLine("Error: Ingrese un numero mayor a 0");
                valpartidas = false;
            }
        } while (!valpartidas);
        int[] jugador = new int[partidas], casa = new int[partidas];
        Console.WriteLine("Ingrese la cantidad de tiros que desea por partida");
        do
        {
            valtiros = int.TryParse(Console.ReadLine(), out tiros);
            if (!valtiros || tiros <= 0 || tiros % 2 != 0)
            {
                Console.WriteLine("Error: Ingrese un número par mayor a 0");
                valtiros = false;
            }
        } while (!valtiros);
        int[][] dado1 = new int[partidas][];
        for (int k = 0; k < partidas; k++)
        {
            dado1[k] = new int[tiros];
        }
        int[][] dado2 = new int[partidas][];
        for (int l = 0; l < partidas; l++)
        {
            dado2[l] = new int[tiros];
        }
        Random dado = new Random();
        for (int i = 0; i < partidas; i++)
        {
            for (int j = 0; j < tiros; j++)
            {
                dado1[i][j] = dado.Next(1, 7);
                dado2[i][j] = dado.Next(1, 7);
            }
        }
        static void DIBUJO(int valor)
        {

            Console.WriteLine("---");
            Console.WriteLine("|"+valor+"|");
            Console.WriteLine("---");


        }
        for (int i = 0; i < partidas; i++)
        {
            for (int j = 0; j < tiros; j++)
            {
                DIBUJO(dado1[i][j]);
                DIBUJO(dado2[i][j]);
            }

            Console.ReadKey();

        }
       
        int tirosganadosj = 0;
        for (int i = 0; i < partidas; i++)
        {
            for (int j = 0; j < tiros; j++)
            {
                if (dado1[i][j] + dado2[i][j] == 6 || dado1[i][j] + dado2[i][j] == 12)
                {
                    jugador[i] += 12;
                    tirosganadosj++;
                }
                else if (dado1[i][j] + dado2[i][j] == 4 || dado1[i][j] + dado2[i][j] == 10)
                {
                    casa[i] += 12;
                }
                else if (dado1[i][j] + dado2[i][j] == 2 || dado1[i][j] + dado2[i][j] == 3 || dado1[i][j] + dado2[i][j] == 5 || dado1[i][j] + dado2[i][j] == 7 || dado1[i][j] + dado2[i][j] == 8 || dado1[i][j] + dado2[i][j] == 9)
                {
                    jugador[i] += dado1[i][j] + dado2[i][j];
                    casa[i] += dado1[i][j] + dado2[i][j];
                    tirosganadosj++;
                }
                else if (dado1[i][j] + dado2[i][j] == 11)
                {
                    casa[i] += 6;
                }
            }
        }
        string[] ganador = new string[partidas];
        int ganaj = 0;
        int ganac = 0;
        for (int i = 0; i < partidas; i++)
        {
            if (jugador[i] > casa[i])
            {
                ganador[i] = "Ganador de la partida " + (i + 1) + ": Jugador";
                ganaj++;
            }
            else if (casa[i] > jugador[i])
            {
                ganador[i] = "Ganador de la partida " + (i + 1) + ": Casa";
                ganac++;
            }
            else
            {
                ganador[i] = "No hay ganador, partida " + (i + 1) + " empatada";
            }
        }
        int vecespares = 0;
        int vecesimpares = 0;
        for (int i = 0; i < partidas; i++)
        {
            for (int j = 0; j < tiros; j++)
            {
                if ((dado1[i][j] + dado2[i][j]) % 2 == 0)
                {
                    vecespares++;
                }
                else
                {
                    vecesimpares++;
                }
            }
        }
        int iguales = 0;
        for (int i = 0; i < partidas; i++)
        {
            for (int j = 0; j < tiros; j++)
            {
                if (dado1[i][j] == dado2[i][j])
                {
                    iguales++;
                }
            }
        }
        int sumapuntosca = 0;
        int sumapuntosju = 0;
        for (int i = 0; i < partidas; i++)
        {
            sumapuntosca += casa[i];
            sumapuntosju += jugador[i];
        }
        Console.Clear();
        Console.WriteLine("--------------------Resultados--------------------");
        Console.WriteLine("Ganadores:");
        for (int i = 0; i < partidas; i++)
        {
            Console.WriteLine("Partida " + (i + 1) + " " + ganador[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Tiros de los dados");
        for (int i = 0; i < partidas; i++)
        {
            Console.WriteLine("Tiradas partida " + (i + 1));
            Console.WriteLine("Dado 1:               Dado 2:");
            Console.WriteLine();
            for (int j = 0; j < tiros; j++)
            {
                Console.WriteLine(dado1[i][j] + "                " + dado2[i][j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tiros ganados por el jugador: " + tirosganadosj);
        Console.WriteLine();
        double elporcentaje = 0;
        double n1 = partidas * tiros;
        double n2 = tirosganadosj / n1;
        double n3 = n2 * 100;
        elporcentaje = n3;
        Console.WriteLine("Porcentaje de victoria: " + elporcentaje + "%");
        Console.WriteLine();
        Console.WriteLine("Resultados impares: " + vecesimpares);
        Console.WriteLine("Resultados pares: " + vecespares);
        Console.WriteLine();
        Console.WriteLine("Tiros iguales: " + iguales);
        Console.WriteLine();
        Console.WriteLine("Punteo final: ");
        Console.WriteLine("Jugador: " + sumapuntosju + " ---------- Casa: " + sumapuntosca);
        Console.WriteLine();
        if (ganaj > ganac)
        {
            Console.WriteLine("¡El ganador final es: Jugador!");
        }
        else if (ganac > ganaj)
        {
            Console.WriteLine("¡El ganador final es: Casa!");
        }
        else
        {
            Console.WriteLine("El juego terminó en empate.");
        }

        Console.ReadKey();
    }
}