using System;

namespace Hackathon
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("ingresa priemra cadena");
            string C1I = Console.ReadLine();
            Console.WriteLine("ingresa segunda cadena del mismo longitud");
            string C2I= Console.ReadLine();

            bool verifica = Verificar(C1I, C2I);
            Console.WriteLine(verifica);
        }

        static bool Verificar(string C1, string C2)
        {
            if (C1.Length == C2.Length)
            {
                foreach (var x in C1)
                {
                    if (!C2.Contains(x))
                    {
                        return false;
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
