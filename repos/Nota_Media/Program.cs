using System;

namespace Nota_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que nota has sacado ¿?");
            double nota = double.Parse(Console.ReadLine());

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("INTRODUCE UNA NOTA VALIDA ENTRE 1 Y 10");
            }
            else if (nota <= 4.99)
            {
                Console.WriteLine("LO LAMENTAMOS HAS SUSPENDIDO, TU NOTA NO LLEGA AL APROBADO");

            }
            else if (nota >= 5 && nota <= 6.99)
            {
                Console.WriteLine("ENHORABUENA, HAS APROBADO");

            }
            else if (nota >= 7 && nota <= 8.99)
            {
                Console.WriteLine("ENHORABUENA, HAS SACADO UN NOTABLE");

            }
            else if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("ENHORABUENA, HAS SACADO UN SOBRESALIENTE");

            }
        }
    }
}
