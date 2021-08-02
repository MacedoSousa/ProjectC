using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_Interativos
{
    class Interativos 
    {
        static void Main(string[] args)
        {
            //for
            for (int i = 0; i < 20; i++)
            {

             Console.WriteLine("Valor de i " + i);

            }
                
            // while Nº
            int contador = 1;
            while (contador < 10)
            {
             Console.WriteLine(contador);
                contador++;
            }

            //while Palavra
            var nome = ("Hello World");
            while (true)
            {
                Console.WriteLine(nome);
                
            }

            // do ~ while  
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } 
            while (j < 1000);


            //foreach
            int[] conjunto = { 1, 2, 3, 4};
            foreach (int numero in conjunto)
            {
                Console.WriteLine("Esse conjunto de elemento tem o valor de " + numero);
            }

        }

       

    }
}
