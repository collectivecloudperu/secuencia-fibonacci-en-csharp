using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresa un número (límite):");
            int limite = int.Parse(Console.ReadLine());
            Fibonacci fibonacciObject = new Fibonacci(limite);
            Console.WriteLine(fibonacciObject.getLimitNumbers());
        }
    }

    class Fibonacci
    {
        private int limite;

        public Fibonacci(int limite)
        {
            this.limite = limite;
        }

        public string getLimitNumbers()
        {
            int a = 0, b = 1;
            string resultado = "";

            for (int i = 0; i < limite; i++)
            {
                resultado += a + " ";
                int temp = a;
                a = b;
                b = temp + b;
            }

            return resultado.Trim();
        }
    }
}