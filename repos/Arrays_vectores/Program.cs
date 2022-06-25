using System;

namespace Arrays_vectores
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] coches = new int[5];
            coches[0] = 10;
            coches[1] = 1;
            coches[2] = 11;
            coches[3] = 3;
            foreach (int coche in coches)
            {
                Console.WriteLine(coche);
            }
            */
            /*
            *
            * 1. Escribir un programa que declare un array de 6 números enteros.

           2. Pedir por teclado los valores de los elementos del array.

           3. Mediante un bucle imprimir por la pantalla el valor de los elementos del array
           separados por comas.

           4. Asimismo, aprovechar el bucle para hacer la siguiente transformación: si el
           valor del elemento es par, hay que sumarle 1 a dicho elemento. En caso
           contrario, hay que restarle 1.

           5. El programa finaliza mostrando de nuevo por pantalla los elementos del array
           separados por comas
           */

            int[] array = new int[6];

            Console.WriteLine("Introduce 6 numeros");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduce un numero"); ;
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)
                {
                    array[i]++;
                    Console.Write("{0} ,", array[i]);
                }
                else if (array[i] % 2 != 0)
                {
                    array[i]--;
                    Console.Write("{0} ,", array[i]);
                }

            }

            /*for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            */


            /*
 * • Escribir un programa que declare un vector de tamaño 10 y que cuente los
números pares que tiene.
• OPCIONAL Pedir por teclado añadir datos al vector
*/
            /*
                        int count = 0;
                        int[] vector = new int[10];

                        for (int i = 0; i < vector.Length; i++)
                        {   
                            Console.WriteLine( "Introduce 1 numero");
                            vector[i] = int.Parse(Console.ReadLine());

                            if (vector[i] % 2 == 0) 
                            {
                                count++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine(count);

                        */



        }
    }
}
