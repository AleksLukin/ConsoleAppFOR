﻿using System;
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
            if (number==1)
            {
                OneTaskApp();
            }
            if (number==2)
            {
                SecondTaskApp();
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

            int maxNumber=Math.Max(firstNumber, secondNumber);
            int minNumber=Math.Min(firstNumber, secondNumber);

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

            if(number>=1000) 
            {
                Console.Write("There`s a number more or equal than thousand");
            }

            for (int i = 1; i < number; i++)
            {
                int square=Convert.ToInt32(Math.Pow(i,2));
                int digitSum = square / 100 + square / 10 % 10 + square % 10;

                if (digitSum > number)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }   
}
