using System;

namespace ProblemaXI
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Se citesc 3 numere reale
             * Sa se afiseze cel mai mare */





            Console.Write("Alegeti primul numar: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Alegeti al doilea numar: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Alegeti al treilea numar: ");
            double c = Convert.ToDouble(Console.ReadLine());





            if (a > b || a > c)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(a);
                Console.ResetColor();
            }
            else if (b > a || b > c)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(b);


                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(c);
                Console.ResetColor();
            }




            Console.ReadLine();




        }
    }
}
