using System;
using System.Collections.Generic;
using System.Linq;

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

             */






            /*----------------------------------OPERACIONES CON NUMEROS A ELEGIR-------------------------------------*/

            /*
            double number2;
            double number1;

            do
            {

                Console.WriteLine("Elige un numero");
                 number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("El numero elegido es {0}", number1);

                Console.WriteLine("Elige un numero");
                 number2 = double.Parse(Console.ReadLine());
                Console.WriteLine("El numero elegido es {0}", number2);


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

            */



            /*---------------------------------------------------------AREA TRIANGULO----------------------------------------------*/

            /*
            Console.WriteLine("Escribe la base del triángulo");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe la altura del triángulo");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double areaTriangulo = (baseTriangulo * (alturaTriangulo / 2));
            Console.WriteLine("El área del triángulo es: {0}", areaTriangulo);

            */

            /*



                string sentence = "Frase para el caso practico de UF1 de Programacion A";

                //FRASE SIN ESPACIOS
                string sentenceNoSpace = sentence.Replace(" ", string.Empty);



                // FRASE A MAYUSCULAS
               var sentenceUpper = sentence.ToUpper();
                //char[] sentenceArray = sentenceUpper.ToCharArray();
                int cont = 0;

                foreach (var letter in sentenceUpper)
                {
                    if(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {


                        Console.WriteLine(letter);
                        cont++;

                    }
                }
                Console.WriteLine(cont);
                //int a, e, i, o, u = 0;
                //int letter;

               //for (letter = 0; letter > sentenceNoSpace.Length; letter++) ;



               // Console.WriteLine(fraseSinEspacio);

                Console.WriteLine("El numero de letras de la frase es: {0}", sentenceNoSpace.Length);
                Console.WriteLine("La frase con mayusculas es: {0}", sentenceUpper);


            */
            /*
            int[] lottoArray =  new int [5]; 

            var rand = new Random();

            Console.WriteLine("Five random integers between 1 and 49:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,5:N0}", rand.Next(0,50));

            Console.WriteLine();
            Console.WriteLine();

            for (int ctr = 0; ctr <= 1; ctr++)
                Console.Write("{0,5:N0}", rand.Next(0, 10));


            */
            /*
            string sentence = "ilerna online 2022";

            Console.WriteLine(sentence.ToUpper().Replace(" ", ""));

            int count_Const = 0;

            int[] sentenceArray = new int[sentence.Length];

            for(int i=0; i<sentence.Length; i++)
            {


                sentenceArray[i] = i;

            }
            Console.WriteLine(sentenceArray);



            */



            /*-----------------------------------------TABLA DE MULTIPLICAR PAC3-------------------------------*/
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

            /*-----------------------------------------EJERCICIO PAC1-------------------------------*/

            /*
            Console.WriteLine("Mi nombre es Martin");
            Console.Write("HOLA");
            Console.ReadLine();
            */


            /*---------------------------------NUMERO MAYOR QUE OTRO---------------------------------------------------*/

            /*
            int A = 7;
            int B = 7;

            if (A > B) { 
                Console.WriteLine("A es mayor que B"); 
            }else if (B > A)
            {
                Console.WriteLine("B es mayor que A");
            }else
            {
                Console.WriteLine("A y B son iguales");
            }

            */


            /*----------------------------------ESTRUCTURA CONDICION-----------------------------------------------------*/


            /*

            if (condicion) {

            }
            else if (){

            }
            else { }

            */


            /*------------------------------------------------------NUMERO PAR E IMPAR---------------------------------*/

            /*

             int numero;

            for (numero = 1; numero <= 100; numero++) {
                if (numero % 2 != 0)
                {
                    Console.WriteLine("El numero {0} es impar", numero);
                    Console.WriteLine("El numero " + numero + " es impar");




                }
                else { 
                        Console.WriteLine("El numero {0} es par", numero);


                         }

                    }

            */


            /*----------------------------VECTOR TAMAÑO 10 QUE IMPRIME PARES-----------------------------------------*/

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
                Console.Write(array[i]+",");
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







        }
}
}
