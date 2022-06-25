using System;

namespace Pildoras_Informaticas
{
    class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random();

            int randomNumber = number.Next(0, 100);

            //Console.WriteLine(randomNumber);

            Console.WriteLine("Elige un numero entre el 0 y el 100 a ver si aciertas...");

            int chosenNumber = int.Parse(Console.ReadLine());

            while (chosenNumber != randomNumber)
            {


                if (chosenNumber > randomNumber)
                {
                    Console.WriteLine("Frio Frio, estas por encima");
                    Console.WriteLine("Elige un numero entre el 0 y el 100 a ver si aciertas...");

                    chosenNumber = int.Parse(Console.ReadLine());
                }

                else if (chosenNumber < randomNumber)
                {
                    Console.WriteLine("Frio Frio, estas por debajo");
                    Console.WriteLine("Elige un numero entre el 0 y el 100 a ver si aciertas...");

                    chosenNumber = int.Parse(Console.ReadLine());
                }

                else chosenNumber = randomNumber;
                
            }
            Console.WriteLine("Has acertado!");








            /*--------------------------------------CALCULO DE AREA DEL CIRCULO----------------------------------*/

            /*
            const double PI = 3.1416;

            Console.WriteLine("Vamos a calcular el área del círculo \n¿Cual es el radio del circulo?");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine("El area del círculo es: {0}", area);

            */




            /* -----------------------------------------------RESULTADO DE UNA SUMA SOLICITADA AL USUARIO----------------*/

            /*
             
            Console.WriteLine("Elige un numero para la suma");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Elige el otro numero para la suma");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es {0}", (num1 + num2));

            */

            /*------------------------------------------TABLA DE MULTIPLICAR DEL NUMERO SELECCIONADO------------------------*/
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

            /* 
            Console.WriteLine("Hello World!");
             
             */

            /*--------------------------------------OPERADORES ARITMETICOS-------------------------VIDEO 5-----------*/

            /*

            int edad = 27;

            edad -= 7;

                Console.WriteLine($"La edad que tienes es {edad++}");
                Console.WriteLine("La edad que tienes es " + ++edad);
                Console.WriteLine("La edad que tienes es {0}", edad);

            
            */



            /*
            int num;

            do
            {
                Console.Write("Ingresa un numero entre el 1 y el 9");
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


            /*----------------------------------------------------------------------------------------------------*/










        }
    }
}
