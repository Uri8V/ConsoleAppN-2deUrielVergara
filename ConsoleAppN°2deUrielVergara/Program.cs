using System;

namespace ConsoleAppN_2deUrielVergara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio2deUrielVergara";

            int Distancia;
            int Velocidad;
            int Tiempo;
            double Conversion;
            float Kms;

            try
            {
                Console.Write("Ingrese la velocidad en la que recorrió ");
                Velocidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el tiempo tardado en segundos ");
                Tiempo = int.Parse(Console.ReadLine());

                Kms = 0.001f;

                Distancia = Velocidad * Tiempo;
                Console.WriteLine($"La distancia recorrida en m/s es {Distancia} ");
                Conversion = Distancia * Kms;
                Console.WriteLine($"La distancia recorrida en metros es equivalente a {Conversion} em Kms");

            }
            catch (Exception)
            {

                Console.WriteLine("Los datos ingresados son erroneos ");
            }
            Console.ReadLine();
        }
    }
}
