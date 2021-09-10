using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecto16_AlturasPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int limite;
            double altura = 0;
            double suma = 0;
            Console.WriteLine("Cuantas Personas Participaran ");
            limite = int.Parse(Console.ReadLine());   //2     
            while (x<=limite)
            {
                Console.Write("Ingrese la altura 0{0} :", x);
                altura = double.Parse(Console.ReadLine());
                if (altura>1.90)
                {
                    Console.WriteLine("No existe personas tan altas ");
                }
                else
                {
                    if (altura>=0 && altura<=1.9)
                    {
                        suma = suma + altura;
                        x = x + 1;
                    }
                    else
                    {
                        Console.WriteLine("No existe alturas negativas ");
                    }
                }
            }
            Console.WriteLine("El promedio de Altura es : {0} ", suma / limite);
            Console.ReadLine();

        }
    }
}
