using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            //if
            int hora = 15;

            if (hora >= 15)
            {
                Console.WriteLine("Já são 15hrs!");
            }

            int clock = 16;

            if (clock >= 15)
            {
                Console.WriteLine("Já passou das 15Hrs!");
            }

            if (clock <= 14)
            {
                Console.WriteLine("Ainda são 14Hrs!");
            }

            //if ~ else if 
            int time = 01;

            if (time >= 15)
            {
                Console.WriteLine("já passou das 15Hrs! ");
            }

            else if (time <= 14)
            {
                Console.WriteLine("Ainda não é 15Hrs! ");
            }

            //if ~ else
            var a = 05;

            if (a >= 12 || a == 00)
            {
                Console.WriteLine(" já é de noite ");
            }

            else if (a >= 06 || a == 11)
            {
                Console.WriteLine("Já é de Manhã ");
            }

            else
            {
                if (a >= 01 || a == 05)
                {
                    Console.WriteLine("Já é de Madrugada");

                }
                else
                {
                    Console.WriteLine("Seu Relógio parou");


                    int m = 18;
                    switch (m)
                    {
                        case 15:
                            Console.WriteLine("são 15Hrs!");
                            break;
                        case 18:
                            Console.WriteLine("são 18Hrs!");
                            break;
                    }


                }
            }

            //switch
            Meses mes = Meses.Novembro;
            switch (mes)
            {
                case Meses.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case Meses.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case Meses.Março:
                    Console.WriteLine("Estamos em Março");
                    break;
                case Meses.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                case Meses.Maio:
                    Console.WriteLine("Estamos em Maio");
                    break;
                case Meses.Junho:
                    Console.WriteLine("Estamos em Junho");
                    break;
                case Meses.Julho:
                    Console.WriteLine("Estamos em Julho");
                    break;
                case Meses.Agosto:
                    Console.WriteLine("Estamos em Agosto");
                    break;
                case Meses.Setembro:
                    Console.WriteLine("Estamos em Setembro");
                    break;
                case Meses.Outubro:
                    Console.WriteLine("Estamos em Outubro");
                    break;
                case Meses.Novembro:
                    Console.WriteLine("Estamos em Novembro");
                    break;
                case Meses.Dezembro:
                    Console.WriteLine("Estamos em Dezembro");
                    break;
            }


            //switch ~ default
            Meses M = Meses.Novembro;
            switch (M)
            {
                case Meses.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case Meses.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case Meses.Março:
                    Console.WriteLine("Estamos em Março");
                    break;
                case Meses.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                default:
                    Console.WriteLine(M + " não foi listado!");
                    break;
            }


        }

        public enum Meses
        { 
            Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro
        }

        
    }
}
