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
            //int[] numbers = new int[] { 3, 10, 1 };

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

            // 0 1 1 2 3 5 8 13 - для 14
            // 0 1 1 - для 2
            // 0 1 1 2 3 - для 4

            // если тек элем-т меньше входного числа, то мы добавляем его к строке "0 1 "

            //int number1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Число равно {0}", number1);

            for (int i = 0; i < numbers.Length; i++)
            {
                FibbSequence(numbers[i]);
                Console.WriteLine();
            }

            /*
            string fibbStr = "01";
            
            int i = 2;
            int tekElem;
            
            while (Fibb(i) < numbers[3])
            {
                fibbStr+=Fibb(i);
                Console.WriteLine(fibbStr);
                i++;
            }
            */

            /*
            /// ПОСЛЕДНЕЕ РАБОТАЮЩЕЕ РЕШЕНИЕ!!!
            int i = 0;
            int tekElem;
            
            while ((tekElem = Fibb(i)) < numbers[2])
            {
                Console.Write(tekElem); // Console.Write(Fibb(i));
                i++;
            }
            */

            //Console.WriteLine(fibbStr);

            /*
            for (int i=2; i < numbers[3]; i++)
            {
                int tekElem = Fibb(i);
                
                while (tekElem < numbers[3])
                {
                    fibbstr+=tekElem;
                }
            }
            */

            //Console.ReadLine();
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

        static void FibbSequence(int n)
        {

            int i = 0;
            int tekElem;

            while ((tekElem = Fibb(i)) < n)
            {
                Console.Write(tekElem); // Console.Write(Fibb(i));
                i++;
            }

            /*
            int i = 0;
            while (Fibb(i) < 5)
            {
                return "a";
            }
            
            return "b";
            
            /*
            string result = "01";
            
            if (n == 1)
            {
                return "0";
            } else {
                for (int i = 2; i < n; i++)
                {
                    result
                }
            }
            */

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
