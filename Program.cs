using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Lab_Tarea1_Progra_Modular.Programas;

namespace Lab_Tarea1_Progra_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Programacion modular");
            Console.WriteLine("1. ¿Año bisiesto?");
            Console.WriteLine("2. Calculo de cuota laboral");
            Console.WriteLine("3. Numero intermedio");
            Console.WriteLine("4. Formula de combinaciones");
            Console.WriteLine("5. Calculo de billetes");
            Console.WriteLine("6. Clasificacion por edad INE");
            Console.WriteLine("7. Sueldo diario");
            Console.WriteLine("8. Sigma");
            Console.WriteLine("9. ¿Que equipo gano?");
            Console.WriteLine("10. Tablas de multiplicar");
            Console.WriteLine(" ");
            Console.WriteLine("Funciones de parametro");
            Console.WriteLine("11. Número perfecto");
            Console.WriteLine("12. Dia de la semana");
            Console.WriteLine("13. Fibonacci");
            Console.WriteLine("14. Formula de A");
            Console.WriteLine("15. ¿Entero negativo o positivo?");
            Console.WriteLine(" ");
            Console.WriteLine("0. Para salir del sistema");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0: 
                    Console.WriteLine("¡Gracias por utilizar mi sistema!");
                    Console.ReadKey();
                    break;

                case 1:
                    Bisiesto();
                    Menu();
                    break;

                case 2:
                    Cuotas();
                    Menu();
                    break;

                case 3:
                    NumeroIntermedio();
                    Menu();
                    break;

                case 4:
                    Combinaciones();
                    Menu();
                    break;

                case 5:
                    CalculoBilletes();
                    Menu();
                    break;

                case 99: //Just for testing purporse
                    FuncionExtra();
                    Menu();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta. Vuelva a intentarlo.");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        
    }
}