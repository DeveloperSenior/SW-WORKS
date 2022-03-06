using System;

namespace WorkOne
{
    class Program
    {
        static void One()
        {
            Console.WriteLine("## Ejercicio 1 ##");
            Console.WriteLine("Ingrese el primer numero");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            string num2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tercer numero");
            string num3 = Console.ReadLine();
            Console.WriteLine("Ingrese el cuarto numero");
            string num4 = Console.ReadLine();

            Console.WriteLine("La suma de los dos primeros es " + (Int32.Parse(num1) + Int32.Parse(num2)));
            Console.WriteLine("El producto del tercero y el cuarto " + (Int32.Parse(num3) * Int32.Parse(num4)));
            

        }
        static void Two()
        {
            Console.WriteLine("## Ejercicio 2 ##");
            Console.WriteLine("Ingrese el primer numero");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            string num2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tercer numero");
            string num3 = Console.ReadLine();
            Console.WriteLine("Ingrese el cuarto numero");
            string num4 = Console.ReadLine();
            int sum = (Int32.Parse(num1) + Int32.Parse(num2) + Int32.Parse(num3) + Int32.Parse(num4));
            float prom = sum / 4;
            Console.WriteLine("La suma  es " + sum);
            Console.WriteLine("El promedio es " + prom);
        }

        static void Three()
        {
            Console.WriteLine("## Ejercicio 3 ##");
            Console.WriteLine("Ingrese el precio del articulo: ");
            string price = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad que desea llevar el cliente: ");
            string count = Console.ReadLine();
            float total = float.Parse(price) * Int32.Parse(count);
            Console.WriteLine("Debe abonar el comprador " + total);
        }

        static void Four()
        {
            Console.WriteLine("## Ejercicio 4 ##");
            string name = "Andres Felipe";
            string city = "Medellin Colombia";
            Console.WriteLine(String.Format("Hola {0} Bienvenido a {1}", name, city));
        }

        static void Five()
        {
            Console.WriteLine("## Ejercicio 5 ##");
            Console.WriteLine("Ingrese la base del triangulo");
            string b = Console.ReadLine();
            Console.WriteLine("Ingrese la altura del triangulo");
            string a = Console.ReadLine();
            float area = (float.Parse(b) * float.Parse(a)) / 2;
            Console.WriteLine("La superficie del triangulo es: " + area);
        }

        static void Six()
        {
            Console.WriteLine("## Ejercicio 6 ##");
            Console.WriteLine("Ingrese un numero");
            string b = Console.ReadLine();
            if (int.Parse(b) > 0)
                Console.WriteLine("El numero es positvio");
            else
                Console.WriteLine("El numero es negativo");
        }

        static void Seven()
        {
            int cant = 0;
            int[] serie = new int[5];
            Console.WriteLine("## Ejercicio 7 ##");
            while (cant < 5)
            {
                Console.WriteLine("Ingrese un numero");
                int num = int.Parse(Console.ReadLine());
                serie[cant] = num;
                ++cant;
            }

            Array.Sort(serie);

            Console.WriteLine(String.Format("Numero menor es: {0} \n Numero Mayor es: {1}", serie[0], serie[4]));

        }

        static void Eight()
        {
            int cant = 0;
            float sum = 0;
            float prom;
            Console.WriteLine("## Ejercicio 8 ##");
            while (cant < 5)
            {
                Console.WriteLine("Ingrese un numero");
                sum += float.Parse(Console.ReadLine());
                ++cant;
            }
            prom = sum / 5;
            Console.WriteLine("El promedio de los 5 numeros es : " + prom);

        }
        static void Nine()
        {
            int cant = 0;
            int may = 0;
            int men = 0;
            int eq = 0;
            Console.WriteLine("## Ejercicio 9 ##");
            while (cant < 10)
            {
                Console.WriteLine("Ingrese un numero");
                float num = float.Parse(Console.ReadLine());
                if (num < 0)
                    men += 1;
                else if (num > 0)
                    may += 1;
                else
                    eq += 1;
                ++cant;
            }
            Console.WriteLine("Cantidad de Mayores a 0: " + may);
            Console.WriteLine("Cantidad de Menores a 0: " + men);
            Console.WriteLine("Cantidad de Iguales a 0: " + eq);

        }

        static void Ten()
        {
            Console.WriteLine("## Ejercicio 10 ##");
            Boolean isPar;
            Console.WriteLine("Ingrese un numero");
            isPar = float.Parse(Console.ReadLine()) % 2 == 0;
            Console.WriteLine(isPar ? "El Numero es Par" : "El Numero es Impar");

        }

        static void Eleven()
        {
            Console.WriteLine("## Ejercicio 11 ##");
            double fahrenheit;
            Console.WriteLine("Ingrese los grados °C");
            fahrenheit = ( float.Parse(Console.ReadLine()) * 1.8 ) + 32;
            Console.WriteLine(String.Format("Los grados Fahrenheit son {0} °F", fahrenheit));

        }

        static void Twelve()
        {
            Console.WriteLine("## Ejercicio 12 ##");
            string name;
            string years;
            Console.WriteLine("Ingresa tu nombre");
            name = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            years = Console.ReadLine();
            Console.WriteLine(String.Format("Te llamas {0} y tienes {1} años",name, years));

        }

        static void Thirteen()
        {
            Console.WriteLine("## Ejercicio 13 ##");
            Console.WriteLine("Ingresa tu capital a invertir");
            double capital = double.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("El valor de retorno es de {0} mensuales", (((capital * 0.02) * 30))));

        }

        static void Fourteen()
        {
            Console.WriteLine("## Ejercicio 14 ##");
            Console.WriteLine("Ingresa tu fecha de nacimiento (DD/MM/YYYY)");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            int yearsOld = (int)(DateTime.Now.Subtract(birthday).Days / 365.2425);
            Console.WriteLine(String.Format("Tu edad es {0} {1}", yearsOld , yearsOld > 1? "años":"año"));
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Empecemos el taller 1!");
            One();
            Two();
            Three();
            Four();
            Five();
            Six();
            Seven();
            Eight();
            Nine();
            Ten();
            Eleven();
            Twelve();
            Thirteen();
            Fourteen();
        }
    }
}
