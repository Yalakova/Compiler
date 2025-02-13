using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0)
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Факториал числа {number} равен {factorial}.");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите неотрицательное целое число.");
            }
            Console.ReadLine();
        }

        static long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    
    }
}
