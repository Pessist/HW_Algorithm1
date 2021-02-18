using System;

namespace Lesson3_CycleFor
{
    /*
     * 
     * 
     * 3. Реализуйте функцию вычисления числа Фибоначчи
     * 
     * Числа Фибоначчи:
     * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711
     * 
     */

    class Program
    {
        static int Main(string[] args)
        {

            int numberA = 6;
            int numberB = 11;
            int checkElemetFibA = 5;
            int checkElemetFibB = 55;

            Console.WriteLine("Вывод элемента запрошеннго числа Фибоначчи\n");

            int resultA = Fibonacci(numberA - 1);
            int resultB = Fibonacci(numberB - 1);
            Console.Write($"Элемент числа Фибоначчи {numberA} равен {resultA}\nЭлемент числа Фибоначчи {numberB} равен {resultB}");

            Console.WriteLine("\n\n\t\t====Проверка====");

            bool check;

            if (check = resultA == checkElemetFibA)
            {
                Console.WriteLine($"Провека первого числа заданного хардком - {check}");
            }
            else
            {
                Console.WriteLine($"В программе ошибка!");
            }

            if (check = resultB == checkElemetFibB)
            {
                Console.WriteLine($"Проверка второго числа заданного хардком - {check}");
            }
            else
            {
                Console.WriteLine($"В программе ошибка!");
            }

            Console.WriteLine();
            return 0;
        }

        public static int Fibonacci(int n)
        {
            int firstNamber = 0, secondNamber = 1;
            int fibonacciSum = 0;
            if (n == 0)
            {
                return firstNamber;
            }
            else if (n == 1)
            {
                return secondNamber;
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    fibonacciSum = firstNamber + secondNamber;
                    firstNamber = secondNamber;
                    secondNamber = fibonacciSum;
                }
                //return (FibonacciFunction(n - 1) + FibonacciFunction(n - 2));
            }
            return fibonacciSum;
        }
    }
}
