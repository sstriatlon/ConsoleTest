using System;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se llama a la funcion con el parametro: \n 'we the people of the united states in order to form a more perfect union etc'\n \n");
            stringRefactor("the rocks");
        }

        public static string stringRefactor(string frase) 
        { 
            //Saco espacios de la cadena
            string trimmedString = frase.Replace(" ", String.Empty);

            //Calculo la longitud de la matriz que voy a crear,redondeando para arriba el Sqrt
            int stringLength = (int)Math.Ceiling(Math.Sqrt(trimmedString.Length));
            char[,] resultArr = new char[stringLength, stringLength];

            //populo el array con los caracteres de acuerdo al pedido
            fillArray(resultArr, trimmedString);

            //imprimo array de acuerdo al pedido
            Console.WriteLine(printArray(resultArr));

            return trimmedString; 
        }

        private static string printArray(char[,] resultArr)
        {
            string result = "";
            for (int h = 0; h < Math.Sqrt(resultArr.Length);h++)
            {
                string word = "";
                for (int l = 0; l < Math.Sqrt(resultArr.Length); l++)
                {
                    word = word + resultArr[l,h];
                }
                result = result + " " + word;
            }

            return result;
        }

        private static void fillArray(char[,] resultArr, string trimmedString)
        {
            int pos = 0;
            char[] chars = trimmedString.ToCharArray();
            for (int h = 0; h < Math.Sqrt(resultArr.Length); h++)
            {
                for (int l = 0; l < Math.Sqrt(resultArr.Length); l++)
                {
                    if (pos < trimmedString.Length)
                    {
                        resultArr[h, l] = chars[pos];
                    }
                    pos++;
                }
            }
        }
    }
}
