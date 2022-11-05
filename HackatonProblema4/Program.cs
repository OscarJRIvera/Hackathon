using System;

namespace HackatonProblema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el total de la suma");
            string total = Console.ReadLine();
            Console.WriteLine("Ingrese el primer numero");
            string n1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            string n2 = Console.ReadLine();
            int num1 = (Convert.ToInt32(n1));
            int num2 = (Convert.ToInt32(n2));

            string cad1 = ConvertirBinario(num1);
            string cad2 = ConvertirBinario(num2);
            string resp = Convert.ToString(ValidarUnos(cad1, cad2));
            Console.WriteLine("Las avellas totales son: " + resp);
        }
        static int ValidarUnos(string cad1, string cad2)
        {
            int contador1 = 0;
            foreach (var x in cad1)
            {
                if (x == '1')
                {
                    contador1++;
                }
            }
            foreach (var x in cad2)
            {
                if (x == '1')
                {
                    contador1++;
                }
            }
            return contador1;
        }
        static string ConvertirBinario(int numero)
        {
            int deci = numero;
            int residuo;
            string binario = "";
            while (deci > 0)
            {
                residuo = deci % 2;
                deci /= 2;
                binario = residuo.ToString() + binario;

            }
            return binario;
        }
    }
}
