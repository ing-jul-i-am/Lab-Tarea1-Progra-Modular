using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tarea1_Progra_Modular
{
    public class Programas
    {
        public static void FuncionExtra()
        {
            Console.WriteLine("Esta es una funcion extra.");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list.Sum());
            Console.ReadKey();
        }

        public static void FIN()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }

        //Opcion 1
        public static void Bisiesto()
        {
            int year;
            Console.Clear();
            Console.WriteLine("¿Año bisiesto?");
            Console.WriteLine("Ingrese el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
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
                }
                else
                {
                    Console.WriteLine(year + " es bisiesto.");
                }
            }
            else
            {
                Console.WriteLine(year + " no es bisiesto.");
            }
            FIN();
        }

        //Opcion 2
        public static void Cuotas()
        {
            Console.Clear();
            Console.WriteLine("Calculo de cuota laboral");
            Console.WriteLine("Ingrese el sueldo base: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La cuota laboral es: " + CuotaLaboral(sueldo));
            Console.WriteLine("La cuota patronal es: " + CuotaPatronal(sueldo));
            Console.WriteLine("Sueldo liquido a recibir es: " + SueldoLiquido(sueldo));
            FIN();
        }

        public static double CuotaLaboral(double sueldo)
        {
            return 0.0483 * sueldo;
        }

        public static double CuotaPatronal(double sueldo)
        {
            return 0.01 * sueldo;
        }

        public static double SueldoLiquido(double sueldo)
        {
            return sueldo - (CuotaLaboral(sueldo) + CuotaPatronal(sueldo));
        }

        //Opcion 3
        public static void NumeroIntermedio()
        {
            Console.Clear();
            Console.WriteLine("Numero intermedio de 3 numeros ingresados");
            Console.WriteLine("Ingrese el primer numero entero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero entero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero entero: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a > b && a < c) || (a < b && a > c))
            {
                Console.WriteLine(a + " es el numero intermedio.");
            }
            else if ((b > a && b < c) || (b < a && b > c))
            {
                Console.WriteLine(b + " es el numero intermedio.");
            }
            else if (b == a || a == c || b == c)
            {
                Console.WriteLine("Resultado impreciso. Hay dos numeros iguales.");
            }
            else
            {
                Console.WriteLine(c + " es el numero intermedio.");
            }
            FIN();
        }

        //Opcion 4
        public static void Combinaciones()
        {
            Console.Clear();
            Console.WriteLine("Formula de combinaciones y permutaciones");
            Console.WriteLine("Ingrese el valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El numero total de combinaciones es: " + FormulaCombinaciones(n, r));
            FIN();
        }

        public static double FormulaCombinaciones(int n, int r)
        {
            return (Factorial(n)) / (Factorial(r) * Factorial(n - r));
        }

        public static double Factorial(int x)
        {
            double sumador = 1;
            for (int i = 1; i <= x; i++)
            {
                sumador = sumador * i;
            }
            return sumador;
        }

        //Opcion 5
        public static void CalculoBilletes()
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

            FIN();
        }

        public static int Billete100(int cant)
        {
            int resultado;
            if (cant >= 100)
            {
                resultado = Convert.ToInt32(cant / 100);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        public static int Billete50(int cant)
        {
            int numero = cant - Billete100(cant) * 100;
            int resultado;

            if (numero >= 50)
            {
                resultado = Convert.ToInt32(numero / 50);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        public static int Billete20(int cant)
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

        public static int Billete10(int cant)
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

        public static int Billete5(int cant)
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

        public static int Billete1(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20 - Billete10(cant) * 10 - Billete5(cant) * 5;

            return numero;
        }

        //Opcion 6
        public static void Clasificacion()
        {
            Console.Clear();
            Console.WriteLine("Clasificacion segun edad de las personas INE");
            Console.WriteLine("Ingrese la edad, en años enteros, de la persona: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ClasificacionPorEdad(edad));

            FIN();
        }

        public static string ClasificacionPorEdad(int edad)
        {
            if(edad <= 5)
            {
                return "Bebe";
            } else if (edad <= 12)
            {
                return "Niño";
            } else if (edad <= 17)
            {
                return "Adolescente";
            } else if (edad<=50)
            {
                return "Adulto";
            } else
            {
                return "Anciano";
            }
        }

        //Opcion 7
        public static void SueldoDiario()
        {
            Console.Clear();
            Console.WriteLine("Calculo del sueldo diario");
            Console.WriteLine("Ingrese el nombre del colaborador: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
            double horas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el pago por hora: ");
            double pago = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("El total a pagar a " + nombre + " es de: ");
            Console.WriteLine("Sueldo normal: " + SueldoNormal(horas, pago));
            Console.WriteLine("Sueldo extra: " + SueldoExtra(horas, pago));
            Console.WriteLine("Total a recibir: " + (SueldoNormal(horas, pago) + SueldoExtra(horas, pago)));

            FIN();

        }

        public static double SueldoNormal(double horas, double pago)
        {
            if(horas <= 8 && horas>=0)
            {
                return horas * pago;
            } else if(horas > 8)
            {
                return 8 * pago;
            } else
            {
                return 0;
            }
        }

        public static double SueldoExtra(double horas, double pago)
        {
            if (horas <= 8 && horas >= 0)
            {
                return 0;
            }
            else if (horas > 8)
            {
                return (horas-8) * pago*1.5;
            }
            else
            {
                return 0;
            }
        }

        //Opcion 8
        public static void Sigma()
        {
            Console.Clear();
            Console.WriteLine("Sigma (1-4)");
            double sumatoria=0;

            for(double n = 1; n <= 4; n++)
            {
                sumatoria += 1 / (n * (n + 2));
            }

            Console.WriteLine("El resultado de la sumatoria es: " + sumatoria);

            FIN();
        }

        //Opcion 9
        public static void EquipoGanador()
        {
            Console.Clear();
            Console.WriteLine("¿Cual es el equipo ganador?");
            
            Console.WriteLine("Nombre del primer equipo: ");
            string A = Console.ReadLine();
            Console.WriteLine("Marcador de A: ");
            int marcadorA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Nombre del segundo equipo: ");
            string B = Console.ReadLine();
            Console.WriteLine("Marcador de B: ");
            int marcadorB = Convert.ToInt32(Console.ReadLine());

            if(marcadorA > marcadorB)
            {
                Console.WriteLine("¡El equipo " + A + " es el equipo ganador!");
            } else if(marcadorB > marcadorA)
            {
                Console.WriteLine("¡El equipo " + B + " es el equipo ganador!");
            } else
            {
                Console.WriteLine("¡Empate!");
            }

            FIN();
        }

        //Opcion 10
        public static void TablasMultiplicar()
        {
            Console.Clear();
            Console.WriteLine("Tablas de multiplicar del 1 al 10");
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para comenzar.");
            Console.ReadKey();

            int m, n;

            for (m = 1; m <= 10; m++)
            {
                for(n=1; n<=10; n++)
                {
                    Console.WriteLine($"{m}X{n}={m * n}");
                }
                Console.WriteLine(" ");
            }

            FIN();
        }

        //FUNCIONES DE PARAMETROS
        //Opcion 11
        public static void NumeroPerfecto()
        {
            Console.Clear();
            Console.WriteLine("Numeros perfectos");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese un numero entero positivo: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El numero {n} es: {Perfecto(n)}");
            FIN();
        }

        public static string Perfecto(int n)
        {
            List<int> divisores = new List<int>();

            for(int i = 1; i < n; i++)
            {
                if(n%i==0)
                {
                    divisores.Add(i);
                }
            }

            if (divisores.Sum() == n)
            {
                return "Perfecto";
            }
            else
            {
                return "Imperfecto";
            }
        }

        //Opcion 12
        public static void DiaDeLaSemana()
        {
            Console.Clear();
            Console.WriteLine("¿Qué día de la semana es?");
            Console.WriteLine(" ");
            Console.WriteLine("Ingresa un numero del 1 al 7: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n>0 && n <= 7)
            {
                Console.WriteLine($"El día {n} es el dia {DiaSemana(n)}.");
            } else
            {
                Console.WriteLine("El numero ingresado es incorrecto. Vuelva a intentarlo.");
            }
            FIN();
        }

        public static string DiaSemana(int n)
        {
            switch (n)
            {
                case 1:
                    return "Lunes";

                case 2:
                    return "Martes";

                case 3:
                    return "Miercoles";

                case 4:
                    return "Jueves";

                case 5:
                    return "Viernes";

                case 6:
                    return "Sabado";

                case 7:
                    return "Domingo";

                default:
                    return "Something went wrong :(";
            }
        }

        //Opcion 13
        public static void SerieFibonacci()
        {
            Console.Clear();
            Console.WriteLine("Serie/Numeros de Fibonacci");
            Console.WriteLine(" ");
            Console.WriteLine("Sabiendo que a1=0 y a2=1, ¿Cúantos valores de Fibonacci desea ver?");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> numeros = new List<int>();
            numeros = Fibonacci(n);

            Console.WriteLine($"Los {n} numeros de fibonacci son: ");
            if (numeros.Count == 1)
            {
                Console.WriteLine(numeros[0]);
            }
            else if (numeros.Count == 2)
            {
                Console.WriteLine(numeros[0]);
                Console.WriteLine(numeros[1]);
            } else
            {
                foreach (int x in numeros)
                {
                    Console.WriteLine(x);
                }
            }

            FIN();
        }

        public static List<int> Fibonacci(int n)
        {
            List<int> serie = new List<int>();
            if(n <= 1)
            {
                serie.Add(0);
            } else if (n<=2)
            {
                serie.Add(0);
                serie.Add(1);
            } else
            {
                serie.Add(0);
                serie.Add(1);
                for(int i = 3; i <= n; i++)
                {
                    serie.Add(serie[i-2] + serie[i-3]);
                }
            }
            return serie;
        }

        //Opcion 14
        public static void FormulaDeA()
        {
            Console.Clear();
            Console.WriteLine("Calculo de la formula de A");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese el valor de P: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El valor de A={A(p, r, n)}");
            FIN();
        }

        public static double A(double p, double r, double n)
        {
            return p * (r*Math.Pow(1+r,n)) / (Math.Pow(1+r,n)-1);
        }

        //Opcion 15
        public static void EnteroPosNeg()
        {
            Console.Clear();
            Console.WriteLine("Entero positivo, negativo o neutral/cero");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese un numero entero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El numero {n} es {EnteroPN(n)}.");
            FIN();
        }

        public static string EnteroPN(int n)
        {
            if(n == 0)
            {
                return "neutral (cero)";
            } else if( n<0)
            {
                return "negativo";
            } else
            {
                return "positivo";
            }
        }
    }
}
