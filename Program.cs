using System;

namespace ConsoleAppFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
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
                if (number == 5)
                {
                    FiftTaskApp();
                }
                if (number == 6)
                {
                    SixTaskApp();
                }
                if (number == 7)
                {
                    SevenTaskApp();
                }
                if (number == 8)
                {
                    EightAppTask();
                }
                if (number == 9)
                {
                    NineAppTask();
                }
                if (number == 10)
                {
                    TenAppTask();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Number of a task did not enter!");
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
            for (int i = 1; i <= quantityNumber; i++)
            {
                Console.Write("Please, enter a quantity numbers: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    count++;
                    sum += number;
                }
            }
            Console.Write("Количество отрицательных четных чисел равно: " + count);
            Console.Write("Сумма отрицательных четных чисел равно: " + sum);
        }
        /// <summary>
        /// Вывести факториал числа n, где гарантируется, что n не больше 10.
        /// </summary>
        static void SixTaskApp()
        {
            Console.WriteLine("Введите число, факториал которого необходимо вычислить. ВНИМАНИЕ! Число должно быть не более 10!");
            int number = 10;

            int count = 1;

            for (int i = 1; i <= number; i++)
            {
                count *= i;
            }
            Console.Write("Факториал числа " + number + " равен: " + count);
        }
        ///<summary>
        /// Числа Фибоначчи(fn) определяется формулами: f0 = f1 = 1; fn = fn = fn-1 + fn-2 при n = 2, 3,... Составить программу определения f - 40-е число Фибоначчи
        /// 0-0 1-1 2-1 3-2 4-3 5-5 6-8 7-13 8-21 9-34 10-55 ... 40-102 334 155.00
        /// </summary>
        static void SevenTaskApp()
        {
            int prevNumber = 0;
            int fibonacchi = 2;
            int nextNumber = 1;
            int i = 2;

            while (i <= 40)
            {
                fibonacchi = prevNumber + nextNumber;
                prevNumber = nextNumber;
                nextNumber = fibonacchi;
                i++;                
            }
            Console.Write("40 число Фибоначчи равно: "+fibonacchi);
        }
        ///<summary>
        ///. Составить программу, проверяющую, является ли заданное натуральное число совершенным, то есть
        ///  равным сумме своих положительных делителей, кроме самого этого числа.
        ///  Например, число 6 равно сумме своих собственных делителей: 1 + 2 + 3.
        /// </summary>
        static void EightAppTask()
        {
            int number = 28;
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " -совершенное число");
            }
            else
            {
                Console.WriteLine(number + " -несовершенное число");
            }
        }
        /// <summary>
        /// Дана непустая последовательность натуральных чисел, за которой следует 0. 
        /// Вычислить сумму положительных элементов последовательности, порядковые номера которых нечетны.
        /// </summary>
        static void NineAppTask()
        {
            int count = 0;
            for (int i = 3; i > 0; i -= 2)
            {
                count += i;
            }
            Console.WriteLine(count);
        }
        /// <summary>
        /// Составить программу, проверяющую, является ли заданное натуральное число палиндромом, то есть
        /// таким, десятичная запись которого читается одинаково слева направо и справа налево.
        /// </summary>
        static void TenAppTask()
        {
            Console.Write("Введите число от 100 до 1000: ");
            string n = Console.ReadLine();
            bool expression = int.TryParse(n, out int result);

            if (expression)
            {
                int firstNumber, secondNumber, thirdNumber;
                firstNumber = result/100;
                secondNumber = result/10;
                secondNumber%=10;
                thirdNumber = result%100;

                if (firstNumber == thirdNumber)
                {
                    Console.Write(result + " -число является палиндромом");
                }
                else
                {
                    Console.Write(result + " -число неявляется палиндромом");
                }
            }
            else
            {
                Console.WriteLine("Число не введено!");
            }
        }

    }
}
