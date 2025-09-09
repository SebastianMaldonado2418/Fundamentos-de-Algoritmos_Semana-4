using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey(); //detenimiento de consola
        }
  
        static void Ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso " +
                $"de Fundamentos de Algoritmo de la carrera {carrera}");
        }

        static void Ejer2()
        {

        }

        static void Ejer3()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());   

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma:"+(num1 + num2));
            Console.WriteLine("Resta"+(num1 - num2));
            Console.WriteLine("Multiplicación" + (num1 * num2));
            Console.WriteLine("División" + divi);


        }

        static void Ejer4()
        {

        }

        static void Ejer5()
        {
            Console.Write("Ingrese un número decimal");
            double num = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(num);   
            double redo = Math.Round(num, 2);
            double cubo = Math.Pow(num, 3);
            double cubica = Math.Pow(num, 1/3);

            Console.WriteLine("Raiz Cuadrada: " + raiz);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Elevado a 3: " + cubo);
            Console.WriteLine("Raiz Cubica: " + cubica);

        }

        static void Ejer6()
        {

        }
    }
}
