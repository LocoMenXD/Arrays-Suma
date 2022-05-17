using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Sumar los valores de un array y mostrar el resultado.


namespace Sumar_Valores_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList numerosList = new ArrayList();
            int suma = 0, cantidad = 0;
            double promedio;


            Console.WriteLine("ingrese la cantidad de numeros: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese número {0}:", (i + 1));
                numerosList.Add(Convert.ToInt32(Console.ReadLine()));
                suma += Convert.ToInt32(numerosList[i]);
            }

 
            {
                Console.WriteLine("la suma de los valores del arreglo es: {0}", suma);
                promedio = suma / numerosList.Count;
                Console.WriteLine("El Promedio es: {0}", promedio);
                Console.WriteLine(numerosList);

            }

            Console.ReadKey();
        }
    }
}
        
