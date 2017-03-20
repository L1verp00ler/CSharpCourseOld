using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите число №" + (i+1));
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            /*
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */

            int min = Min(numbers);
            Console.WriteLine("Наименьшее число: " + min);
            Console.WriteLine("Последовательности Фиббоначчи:");

            //int number1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Число равно {0}", number1);
            Console.ReadLine();
        }

        static int Min(int[] numbersArr)
        {
            int min;
            if (numbersArr[0] < numbersArr[1] && numbersArr[0] < numbersArr[2])
            {
                min = numbersArr[0];
            } else if (numbersArr[1] < numbersArr[2])
            {
                min = numbersArr[1];
            } else
            {
                min = numbersArr[2];
            }
            return min;
        }

        static int Fibb(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            } else
            {
                return (Fibb(n - 1) + Fibb(n - 2));
            }
        }

    }
}
