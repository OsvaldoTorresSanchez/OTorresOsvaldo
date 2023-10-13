using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {

        public static void Fibo()
        {
            int b=0;
            int numero = 5;
            int result = 0; 
            int a = 0;
            int i = 0;

            Console.WriteLine("Escribe la cantidad de numero");
            
            for (i = 0; i <= numero; i++)
            {

                result = a;
                b = result;
            Console.WriteLine("Resultado" + b);
            }
        }
        
        


    }
}
