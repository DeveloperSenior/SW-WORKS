using System;

namespace PartialOne
{
    class Program
    {

        static void One()
        {
            double note;
            int count = 0;
            int major = 0;
            int minor = 0;
            while ( count < 10)
            {
                Console.Write("Ingresa la nota: ");
                note = double.Parse(Console.ReadLine());
                if (note >= 7)
                    ++major;
                else
                    ++minor;
                ++count;
            }
            Console.WriteLine(string.Format("Las notas mayores son {0} \n Las notas menores son {1}.",major,minor));
            Console.ReadKey();

        }

        static void Two()
        {
            Console.Write("Cuantas Alturas quieres ingresar? ");
            int n = int.Parse(Console.ReadLine());
            double prom;
            double sum = 0;
            int count = 0;
            while (count <= n)
            {
                Console.Write("Ingresa la altura: ");
                sum += double.Parse(Console.ReadLine());
                ++count;
            }
            prom = sum / n;
            Console.WriteLine(string.Format("El promedio de {0} personas es {1}.",n, prom));
            Console.ReadKey();
        }

        static void Three()
        {
            Console.Write("Cuantos numeros quieres ingresar? ");
            int n = int.Parse(Console.ReadLine());
            int par = 0;
            double impar = 0;
            int count = 0;
            while (count <= n)
            {
                Console.Write("Ingresa el numero: ");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    ++par;
                else
                    ++impar;
                ++count;
            }
            Console.WriteLine(string.Format("Pares: {0} ; Impares {1}.", par, impar));
            Console.ReadKey();
        }

        static void Four()
        {
            int count = 0;
            int cantMinor = 0;
            while (count < 3)
            {
                Console.Write("Ingresa un numero: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 10)
                    ++cantMinor;

                ++count;
            }

            if(cantMinor == count)
            { 
            Console.WriteLine("Todos los numeros son menores a 10");
            Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            One();
            Two();
            Three();
            Four();
        }
    }
}
