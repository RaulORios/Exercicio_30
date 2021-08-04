using System;

namespace Exercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 29     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int n1;
            int n2;
            int n3;
            int m1;
            int m2;
            int m3;



            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if ((n1 == n2) || (n2 == n3) || (n1 == n3))
            {
                Console.WriteLine("Operação cancelada, não deve haver números iguais.");
            }
            else if ((n1 < n2) && (n1 < n3))
            {
                m1 = n1;
            }
            if (n2 < n3)
            {
                m2 = n2;
                m3 = n3;
            }
            else if ((n2 < n1) && (n2 < n3))
            {
                m1 = n2;
            }
            if (n1 < n3)
            {
                m2 = n1;
                m3 = n3;
            }
            else 
            {
                m1 = n3;
            }
            if (n1 < n2)
            {
                m2 = n1;
                m3 = n2;
            }
            else
            {
                m2 = n2;
                m3 = n1;
            }
                                                         
            Console.WriteLine($"Sequência: {n1}, {n2}, {n3}. ");

            Console.ReadKey();
        }
    }
}
