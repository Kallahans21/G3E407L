using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenido, vamos a resolver la ecuación x = (X2-X1)^2 + (Y2-Y1)^2");
            //Declaración de variables
            Double X1, X2, Y1, Y2, X, PX, PY;
            //Entrada de datos
            Console.Write("\nPara comenzar, digite los valores de: ");
            Console.Write("Valor de X1\n");
            X1 = Double.Parse(Console.ReadLine());
            Console.Write("Valor de X2\n");
            X2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de Y1");
            Y1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de Y2");
            Y2 = Double.Parse(Console.ReadLine());
            //Proceso de la Ec.
            PX = (X2 - X1);
            PY = (Y2 - Y1);
            X = (Math.Pow(PX, 2)) + (Math.Pow(PY, 2));
            //Salida de datos

            Console.WriteLine("El resultado de la ecuación x = (X2-X1)^2 + (Y2-Y1)^2 es de: " + X);
            Console.ReadKey();
        
            
        }
    }
}
