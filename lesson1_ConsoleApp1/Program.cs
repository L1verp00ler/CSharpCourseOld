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
            
            // Получаем от пользователя 3 числа (сюда еще добавить проверку на ввод "левых" значений!!!)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите число №" + (i+1));
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            // Определяем наименьшее из 3-ёх введенных чисел и выводим его в консоль
            int min = Min(numbers);
            Console.WriteLine("Наименьшее число: " + min);
            
            Console.WriteLine("Последовательности Фиббоначчи:");
            // Выводим последовательности Фиббоначчи, последний элемент каждой из которых меньше соответствующего из 3-ёх чисел (3 последовательности)
            // 0 1 1 2 3 5 8 13 - пример для числа "14"
            for (int i = 0; i < numbers.Length; i++)
            {
                FibbSequence(numbers[i]);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        // Вычисление наименьшего числа
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

        // Вывод последовательности Фиббоначчи, в которой последний элемент меньше заданного числа
        static void FibbSequence(int n)
        {
            int i = 0;
            int tekElem;

            while ((tekElem = Fibb(i)) < n) // while (Fibb(i) < n)
            {
                Console.Write(tekElem); // Console.Write(Fibb(i));
                i++;
            }
        }

        // вычисление n-ного элемента последовательности Фиббоначчи
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
