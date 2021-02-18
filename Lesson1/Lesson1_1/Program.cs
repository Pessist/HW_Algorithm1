using System;

namespace Lesson1_1
{
    /*
     * 
     * 1. Требуется реализовать на C# функцию согласно блок-схеме. 
     * Блок-схема описывает алгоритм проверки, простое число или нет.
     * 
     * 
     */

    class Program
    {

        static int Check(int namber, int d = 0, int i = 2)
        {
            while (i < namber)
            {
                if (namber % i == 0)
                {
                    d++;
                }

                i++;
            }

            return d;
        }

        static void Main(string[] args)
        {

            int firstNamber = 4;
            int secondNamber = 101;

            int firstresult = Check(firstNamber);
            int secondresult = Check(secondNamber);

            try
            {
                if (firstresult == 0)
                {
                    Console.WriteLine($"Число {firstNamber} является простым");
                }
                else
                {
                    Console.WriteLine($"Число {firstNamber} не простое");
                }

                if (secondresult == 0)
                {
                    Console.WriteLine($"Число {secondNamber} является простым");
                }
                else
                {
                    Console.WriteLine($"Число {secondNamber} не простое");
                }
            }
            catch
            {
                Console.WriteLine("В программе ошибка!");
            }

            Test(firstresult, secondresult);

        }

        // По условию программы d возвращает два значения 0 (простое) и 1 (не простое). 
        static void Test(int firstN, int secondN)
        {
            Console.WriteLine("\n\n\t\t====Проверка====");

            bool check;
            int checkFirstNumber = 1; //т.к. мы знаем, что 1е число заданное хардкодом не простое.
            int checkSecondNuber = 0; //т.к. мы знаем, что 2е число заданное хардкодом является простым.

            if (check = firstN == checkFirstNumber)
            {
                Console.WriteLine($"Провека первого числа заданного хардком - {check}");
            }
            else
            {
                Console.WriteLine($"В программе ошибка!");
            }

            if (check = secondN == checkSecondNuber)
            {
                Console.WriteLine($"Проверка второго числа заданного хардком - {check}");
            }
            else
            {
                Console.WriteLine($"В программе ошибка!");
            }
        }
    }
}
