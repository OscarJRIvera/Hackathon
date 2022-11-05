using System;

namespace HackatonProblema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un array de char/cadena");
            string cadena = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad maxima de caracteres por linea");
            int maximo = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            string cadenanueva = "";
            foreach(var x in cadena)
            {
                cadenanueva = cadenanueva + x;
                contador++;
                if (contador == maximo)
                {
                    cadenanueva = cadenanueva + '\n';
                    contador = 0;
                }

            }
            int cuanto_falta = 10 - (cadenanueva.Length % 10);
            if (cuanto_falta < 10)
            {
                for (int i = 0; i < cuanto_falta; i++)
                {
                    cadenanueva = cadenanueva + " ";
                }
            }
            Console.WriteLine(cadenanueva);
        }
        
    }
}
