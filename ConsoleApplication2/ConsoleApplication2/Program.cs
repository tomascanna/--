using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            ArrayList numeros = new ArrayList(50);

            int i = 0;
            var menor=0;
           
            for (i = 0; i < numeros.Count; i++)
            {
                numeros.Add(r.Next());
            }

            Console.WriteLine("la cantidad de elementos del arraylist es de: " + numeros.Capacity);
            Console.ReadKey();
          

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
