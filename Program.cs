using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, type a number task: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                OneTaskApp();
            }
            if (number == 2)
            {
                SecondTaskApp();
            }
            if (number == 3)
            {
                ThridTaskApp();
            }
            if (number == 4)
            {
                FourTaskApp();
            }
            if (number==5)
            {
                FiftTaskApp();
            }
            else
            {
                Console.WriteLine("Число не введено!");
            }
            Console.ReadLine();
        }
        ///<summary>
        ///Выведите обратную последовательность нечетных чисел на отрезке от a до b, где неизвестно какая переменная больше.
        ///</summary>

        static void OneTaskApp()
        {
            Console.Write("Please, enter any number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please, enter another number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = Math.Max(firstNumber, secondNumber);
            int minNumber = Math.Min(firstNumber, secondNumber);

            for (int i = maxNumber; i >= minNumber; i--)
            {
                Console.Write(i);
            }
        }
        ///<summary>
        ///По данному числу n найдите те числа, где сумма цифр квадрата числа больше n. Гарантируется, что n меньше 1000.
        /// </summary>
        static void SecondTaskApp()
        {
            Console.Write("Please, enter a number till 1000: ");
            uint number = uint.Parse(Console.ReadLine());

            if (number >= 1000)
            {
                Console.Write("There`s a number more or equal than thousand");
            }

            for (int i = 1; i < number; i++)
            {
                int square = Convert.ToInt32(Math.Pow(i, 2));
                int digitSum = square / 100 + square / 10 % 10 + square % 10;

                if (digitSum > number)
                {
                    Console.WriteLine(i);
                }
            }
        }
        ///<summary>
        ///Найти сумму введенных пользователем десяти чисел.
        /// </summary>
        static void ThridTaskApp()
        {
            int sum = 0;
            int number;

            for (int i = 0; i <= 11; i++)
            {
                Console.Write("Please, enter a number: ");
                number = int.Parse(Console.ReadLine());

                sum += number;
            }
            Console.Write("Сумма 10 чисел равна: " + sum);
        }

        /// <summary>
        /// Выведите количество натуральных делителей целого числа x, исключая 1 и само число.
        /// </summary>
        static void FourTaskApp()
        {
            Console.Write("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0 && i != 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество делителей равно: " + count);
        }
        /// <summary>
        /// Пользователь ввел n чисел. Найти сумму и количество отрицательных четных чисел.
        /// </summary>
        static void FiftTaskApp()
        {
            Console.Write("Please, enter a quantity numbers: ");
            int quantityNumber = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;
            for (int i = 1;i <= quantityNumber; i++)
            {
                Console.Write("Please, enter a quantity numbers: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    count++;
                    sum += number;
                }
            }
            Console.Write("Количество отрицательных четных чисел равно: "+count);
            Console.Write("Сумма отрицательных четных чисел равно: "+sum);


        }
    }
}
