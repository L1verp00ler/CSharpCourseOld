using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите число: ");
            if (!((number = Int32.Parse(Console.ReadLine())) > 0))
            {
                Console.WriteLine("Число должно быть больше нуля!");
                Console.ReadLine();
            }

            int[] numbersArray = new int[number];
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                numbersArray[i] = rnd.Next();
                Console.WriteLine(numbersArray[i]);
            }



            //Console.WriteLine("123");
            Console.ReadLine();
        }

        static int[] BubbleSort(int[] numbersArray, out int[] sortNumbersArray)
        {

            // { 7, 5, 6, 3, 1, 4 } - массив из 6-ти элементов
            for (int i = 0; i < numbersArray.Length - (i + 1); i++)
            {
                //for (int j = 0; numbersArray.Length - j > 0 ; j++)
                for (int j = 0; j < numbersArray.Length - (i + 1); j++) // numbersArray.Length = 6, т.е. j < 5
                {
                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        int tempElem = numbersArray[j + 1];
                        numbersArray[j + 1] = numbersArray[j];
                        numbersArray[j] = tempElem;
                    }
                }
            }

            // 0 - 7,5,6,3,1,4 j=0
            // 1 - 5,7,6,3,1,4 j=1
            // 2 - 5,6,7,3,1,4 j=2
            // 3 - 5,6,3,7,1,4 j=3
            // 4 - 5,6,3,1,7,4 j=4
            // 5 - 5,6,3,1,4,7 j=5



            int[] array = { 1, 2, 3 };
            return array;
        }
    }
}
