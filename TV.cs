using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Variaveis
{
    class Numeros
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            Console.WriteLine("Numero Inicial da classe é " + numero1);

            int numero2 = numero1;
            Console.WriteLine("O Numero copiado referenciado é " + numero2);

            int soma = numero1 + numero2;
            Console.WriteLine(soma);

            var quadrado1 = new Quadrado();
            quadrado1.lado = numero1;
            var quadrado2 = quadrado1;
            quadrado2.lado = numero1 - soma;

            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
        }


        class Quadrado
        {
            public int lado;



        }

    }

}
