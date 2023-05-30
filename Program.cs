using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor = 5;
            


            for(int i=1; i <= 10; i++) 
            {
                int resultado = valor * i;
                Console.WriteLine(valor + "x" + i + "=" + resultado);
            }

           }
        }
    }

