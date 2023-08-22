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
            if (number==1)
            {
                OneTaskApp();
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

            Console.WriteLine("Please, enter another number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber=Math.Max(firstNumber, secondNumber);
            int minNumber=Math.Min(firstNumber, secondNumber);

            for (int i = maxNumber; i >= minNumber; i--)
            {
                Console.Write(i);
            }
        }

    }
}
