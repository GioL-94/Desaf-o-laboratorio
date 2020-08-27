using System;
using System.Collections.Generic;
using System.Text;
namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int n =0;
            int idmin = 0;
            int idmax = 0;
            String valor = "";
            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine("Por favo ingrese la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            float[] calificaciones = new float[cantidad];

            for(n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese la calificación para el alumno {0}", n + 1);
                valor = Console.ReadLine();
                calificaciones[n] = Convert.ToSingle(valor);
            }

            for(n = 0; n < cantidad; n++)
            {
                suma += calificaciones[n];
            }

            promedio = suma / cantidad;


            for(n = 0; n < cantidad; n++)
            {
                if(calificaciones[n] < minima)
                {
                    minima = calificaciones[n];
                    idmin = n + 1;
                }
            }

            for (n = 0; n < cantidad; n++)
            {
                if (calificaciones[n] > maxima)
                {
                    maxima = calificaciones[n];
                    idmax = n + 1;
                }
            }

            Console.WriteLine("El promedo es: {0}", promedio);

            Console.WriteLine("La calificación mínima es: {0}, del alumno {1}", minima, idmin);
            Console.WriteLine("La calificación máxima es: {0}, del alumno {1}", maxima, idmax);

        }
    }
}
