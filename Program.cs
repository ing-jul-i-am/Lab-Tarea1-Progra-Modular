using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                    Console.WriteLine("Ingrese n para factorial: ");
                    int  n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Factorial(n));
                    Console.ReadKey();
                    Menu();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta. Vuelva a intentarlo.");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        //Opcion 1
        static void Bisiesto()
        {
            int year;
            Console.Clear();
            Console.WriteLine("¿Año bisiesto?");
            Console.WriteLine("Ingrese el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            if(year%4 == 0) {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " es bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine(year + " no es bisiesto.");
                    }
                } else
                {
                    Console.WriteLine(year + " es bisiesto.");
                }
            } else
            {
                Console.WriteLine(year + " no es bisiesto.");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }

        //Opcion 2
        static void Cuotas()
        {
            Console.Clear();
            Console.WriteLine("Calculo de cuota laboral");
            Console.WriteLine("Ingrese el sueldo base: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La cuota laboral es: " + CuotaLaboral(sueldo));
            Console.WriteLine("La cuota patronal es: " + CuotaPatronal(sueldo));
            Console.WriteLine("Sueldo liquido a recibir es: " + SueldoLiquido(sueldo));
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }

        static double CuotaLaboral(double sueldo)
        {
            return 0.0483 * sueldo;
        }

        static double CuotaPatronal(double sueldo)
        {
            return 0.01 * sueldo;
        }

        static double SueldoLiquido(double sueldo)
        {
            return sueldo-(CuotaLaboral(sueldo)+CuotaPatronal(sueldo));
        }

        //Opcion 3
        static void NumeroIntermedio()
        {
            Console.Clear();
            Console.WriteLine("Numero intermedio de 3 numeros ingresados");
            Console.WriteLine("Ingrese el primer numero entero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero entero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero entero: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a>b && a<c) || (a<b && a>c))
            {
                Console.WriteLine(a + " es el numero intermedio.");
            } else if ((b > a && b < c) || (b < a && b > c))
            {
                Console.WriteLine(b + " es el numero intermedio.");
            } else if (b==a || a ==c || b==c)
            {
                Console.WriteLine("Resultado impreciso. Hay dos numeros iguales.");
            } else
            {
                Console.WriteLine(c + " es el numero intermedio.");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }

        //Opcion 4
        static void Combinaciones()
        {
            Console.Clear();
            Console.WriteLine("Formula de combinaciones y permutaciones");
            Console.WriteLine("Ingrese el valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El numero total de combinaciones es: " + FormulaCombinaciones(n, r));
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }

        static double FormulaCombinaciones(int n, int r)
        {
            return (Factorial(n))/(Factorial(r)*Factorial(n-r));
        }

        static double Factorial(int x)
        {
            double sumador = 1;
            for(int i=1; i<=x; i++)
            {
                sumador = sumador * i;
            }
            return sumador;
        }

        //Opcion 5
        static void CalculoBilletes()
        {
            Console.Clear();
            Console.WriteLine("Calculo de los billetes");
            Console.WriteLine("Ingrese una cantidad exacta (sin decimales) de dinero: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            //Para calcular cuantos de Q100
            Console.WriteLine(Billete100(cant) + " billetes de Q100.");

            //Para calcular cuantos de Q50
            Console.WriteLine(Billete50(cant) + " billetes de Q50.");

            //Para calcular cuantos de Q20
            Console.WriteLine(Billete20(cant) + " billetes de Q20.");

            //Para calcular cuantos de Q10
            Console.WriteLine(Billete10(cant) + " billetes de Q10.");

            //Para calcular cuantos de Q5
            Console.WriteLine(Billete5(cant) + " billetes de Q5.");

            //Para calcular cuanto de Q1
            Console.WriteLine(Billete1(cant) + " billetes de Q1");

            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }

        static int Billete100(int cant)
        {
            int resultado;
            if (cant >= 100)
            {
                resultado = Convert.ToInt32(cant / 100);
            } else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete50(int cant)
        {
            int numero = cant - Billete100(cant) * 100;
            int resultado;

            if (numero>=50)
            {
                resultado = Convert.ToInt32(numero / 50);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete20(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50;
            int resultado;

            if (numero >= 20)
            {
                resultado = Convert.ToInt32(numero / 20);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete10(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20;
            int resultado;

            if (numero >= 10)
            {
                resultado = Convert.ToInt32(numero / 10);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete5(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20 - Billete10(cant) * 10;
            int resultado;

            if (numero >= 5)
            {
                resultado = Convert.ToInt32(numero / 5);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete1(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20 - Billete10(cant) * 10 - Billete5(cant)*5;

            return numero;
        }
    }
}