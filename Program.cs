using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int   kciudades, velocidad , tiempo;
            Console.WriteLine("ingrese la distancia de ambas ciudades");
            kciudades = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la velocidad promedio");
            velocidad = int.Parse(Console.ReadLine());
            tiempo = kciudades / velocidad;
            Console.WriteLine("el tiempo aproximado es: "+ tiempo);
        }
    }
}
