using System;
using System.Collections.Generic;
using System.Text;

namespace Escolha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ESTÁ É UMA CALCULADORA SUPER INTELIGENTE");

            Console.WriteLine("escolha um numero ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("escolha outro numero");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite 1 para dividir");
            Console.WriteLine("digite 2 para somar");
            Console.WriteLine("digite 3 para multiplicar");
            Console.WriteLine("digite 4 para subtrair");
            

            // operações

            int i = Convert.ToInt32(Console.ReadLine()); ;

            switch (i)

            {
                case 1:                    
                    decimal c = (a / B);
                    Console.WriteLine(Math.Round(c, 3));
                    break;
                case 2:
                    decimal d = (a + B);
                    Console.WriteLine(+(a + B));
                    break;
                case 3:
                    decimal e = (a * B);
                    Console.WriteLine(+(a * B));
                    break;
                case 4:                    
                    decimal f = (a - B);
                    Console.WriteLine(+(a - B));
                    break;
                    
                default:
                    Console.WriteLine("other");
                    break;

                    Console.ReadKey();
                   







            }


























        }
    }
}
