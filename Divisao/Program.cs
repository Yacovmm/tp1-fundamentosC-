using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro Número:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da divisão é: " + dividir(x, b));
            Console.ReadKey();

        }

        public static int dividir(int x, int b)
        {
            return x / b;
        }
    }
}
