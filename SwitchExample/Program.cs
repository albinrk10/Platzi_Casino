// See https://aka.ms/new-console-template for more information
using System;


Console.WriteLine("Hello, World!");

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlaOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();
//Blackjack, Juntar21 pidiendo cartas o en caso de tener menos de 21 igual tener mayo puntuacion que el dealer
while (true)
{
    Console.WriteLine("Welcome al P L A T Z I N O");
    Console.WriteLine("Cuantos PlatziCoins deseas?\n" +
        "Ingresa un numero entero\n" +
        "Recuerda que necesitas una por ronda");

    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {



        totalJugador = 0;
        totalDealer = 0;
        switch (switchControl)
        {

            case "menu":

                Console.WriteLine("Escriba '21' para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":

                do
                {

                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu  carta, jugador");
                    Console.WriteLine($"Te salio el numero: {num} ");
                    Console.WriteLine("Deseas otra carta?");
                    controlaOtraCarta = Console.ReadLine();

                } while (controlaOtraCarta == "Si" || controlaOtraCarta == "si" || controlaOtraCarta == "yes");
                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El Diler tiene: {totalDealer}!");


                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador > 21)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdistes vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condicion no valida";
                    switchControl = "menu";
                }
                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no valido en el C A S I N O");
                switchControl = "menu";
                break;

        }
    }
}