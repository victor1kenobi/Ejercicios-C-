using System;

namespace PAC_Desarrollo_UF1_SanchezLopez_VictorMiguel
{
    class Program
    {
        static void Main(string[] args)

        {
            // CREAMOS STRING CON LA FRASE, LA CONVERTIMOS EN MAYUSCULAS Y ELIMINAMOS LOS ESPACIOS

            string sentence = ("javas cript 1234");
            string sentenceUpper = sentence.ToUpper();
            string sentenceUpperNoGaps = sentenceUpper.Replace(" ", "");

            Console.WriteLine(sentenceUpperNoGaps);
           
            //CREAMOS CHAR ARRAY CON LA FRASE PARA PODER RECORRERLA POSTERIORMENTE
            char[] sentenceArray = sentence.ToCharArray();

            //DECLARAMOS LA VARIABLE QUE CONTARÁ LAS CONSONANTES
            int contLetters = 0;
         
            //USAMOS UN BUCLE PARA IR CONFIRMANDO SI SON CONSONANTES Y EN SU CASO SUMAMOS A LA VARIABLE CONTLETTERS
            foreach (char letter in sentenceArray)
            {
                if (letter == 'b' || letter == 'c' || letter == 'd' || letter == 'f' || letter == 'g'
                    || letter == 'h' || letter == 'j' || letter == 'k' || letter == 'l' || letter == 'm'
                    || letter == 'n' || letter == 'ñ' || letter == 'p' || letter == 'q' || letter == 'r'
                    || letter == 's' || letter == 't' || letter == 'v' || letter == 'w' || letter == 'x'
                    || letter == 'y' || letter == 'z' )
                {
                    contLetters++;

                }
            }
            
            Console.WriteLine(contLetters);

                 
            // USAMOS LA MISMA OPERACION PARA CONTAR LOS NUMEROS
            int contNumbers = 0;

            foreach (char number in sentenceArray)
            {
                if (number == '0' || number == '1' || number == '2' || number == '3' || number == '4'
                    || number == '5' || number == '6' || number == '7' || number == '8' || number == '9'
)
                {
                    contNumbers++;

                }
            }

            Console.WriteLine(contNumbers);

            //USAMOS EL BUCLE QUE UTILIZAMOS ANTERIORMENTE PARA CONTAR LAS CONSONANTES PERO EN VEZ DE IMPRIMIR EL NUMERO 
            //IMPRIMIMOS DIRECTAMENTE LAS QUE SE VAN LOCALIZANDO EN ORDEN

            foreach (char letter in sentenceArray)
            {
                if (letter == 'b' || letter == 'c' || letter == 'd' || letter == 'f' || letter == 'g'
                    || letter == 'h' || letter == 'j' || letter == 'k' || letter == 'l' || letter == 'm'
                    || letter == 'n' || letter == 'ñ' || letter == 'p' || letter == 'q' || letter == 'r'
                    || letter == 's' || letter == 't' || letter == 'v' || letter == 'w' || letter == 'x'
                    || letter == 'y' || letter == 'z')
                {
                   
                    Console.Write(letter);

                }
            }
           
        }
    }
}
