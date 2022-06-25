using System;

namespace Operaciones_con_numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            double number2;
            double number1;

            do
            {

                Console.WriteLine("Elige un numero");
                number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("El numero elegido es {0}", number1);
                Console.WriteLine();

                Console.WriteLine("Elige un numero");
                number2 = double.Parse(Console.ReadLine());
                Console.WriteLine("El numero elegido es {0}", number2);
                Console.WriteLine();
                

                if (number2 == 0)
                {
                    Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
                }
                else
                {

                    Console.WriteLine("La suma de {0} y {1} es: {2}", number1, number2, (number1 + number2));
                    Console.WriteLine("La resta de {0} y {1} es: {2}", number1, number2, (number1 - number2));
                    Console.WriteLine("La multiplicación de {0} y {1} es: {2}", number1, number2, (number1 * number2));
                    Console.WriteLine("La división de {0} y {1} es: {2}", number1, number2, (number1 / number2));
                }
            } while (number2 == 0);


            /*
int num;

do
{
    Console.Write("Ingresa un numero entre el 1 y el 9\n");
    num = Int32.Parse(Console.ReadLine());

} while (num < 1 || num > 9);

for (int i = 1; i < 10; i++)
    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

Console.Read();

*/


        }
    }
}
