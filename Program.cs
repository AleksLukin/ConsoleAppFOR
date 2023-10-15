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
                if (number == 11)
                {
                    ElevenAppTask();
                }
                if (number == 12)
                {
                    TwelfeAppTak();
                }
                if (number == 13)
                {
                    ThirdTenAppTask();
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
            Console.Write("40 число Фибоначчи равно: " + fibonacchi);
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
                firstNumber = result / 100;
                secondNumber = result / 10;
                secondNumber %= 10;
                thirdNumber = result % 100;

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
        /// <summary>
        /// Числа Фибоначчи(fn) определяется формулами: f0= f1 = 1; fn = fn = fn-1 + fn-2 при n = 2, 3,... Составить
        /// программу вычисления s - суммы всех чисел Фибоначчи, которые не превосходят 1000 
        /// </summary>
        static void ElevenAppTask()
        {
            int prevNumber = 0;
            int nextNumber = 1;
            int fibonacci = 2;
            int i = 2;
            int sumFibonacci = 1;


            while (i <= 20)
            {
                fibonacci = prevNumber + nextNumber;
                prevNumber = nextNumber;
                nextNumber = fibonacci;
                i++;
                sumFibonacci += fibonacci;

                if (sumFibonacci<1000)
                {
                    Console.WriteLine(sumFibonacci); 
                }
                               
            }            
        }
        /// <summary>
        /// Найти первую цифру числа.         
        /// </summary>
        static void TwelfeAppTak()
        {
            Console.Write("Введите число от 100 до 1000: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber, secondNumber, thirdNumber;

            firstNumber = number / 100;
            secondNumber = number / 10;
            secondNumber%=10;
            thirdNumber=number % 10;

            Console.Write("Первое число равно: " + firstNumber);
        }
        /// <summary>
        /// Подсчитать сумму квадратов первых нечетных чисел меньших заданного Z.
        /// </summary>
        static void ThirdTenAppTask()
        {
            Console.Write("Зададим число z: ");
            string s=Console.ReadLine();
            bool number = int.TryParse(s, out int result);
            double sum = 0;

            if (number)
            {
                for (int i = 1; i < result; i+=2)
                {
                    sum += Math.Pow(i, 2);
                }
                Console.Write("Сумма квадратов нечетных чисел, меньших {0} равна {1}",result,sum);
            }
            else
            {
                Console.WriteLine("Число не введено!");
            }
        }
    }
}







