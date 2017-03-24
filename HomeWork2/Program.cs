using System;

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

            //int[] numbersArray = new int[number];
            //Random rnd = new Random();
            int[] numbersArray = { 9, 7, 5, 4, 2, 1 };

            /*
            for (int i = 0; i < number; i++)
            {
                numbersArray[i] = rnd.Next();
                Console.WriteLine(numbersArray[i]);
            }
            */

            int[] sortedNumbersArray = BubbleSort(numbersArray);

            Console.Write("Отсортированный массив чисел: ");
            foreach (int i in sortedNumbersArray)
            {
                Console.Write(i + " ");
            }

            //Console.WriteLine("123");
            Console.ReadLine();
        }

        // Эта сортировка во внутреннем цикле будет идти до определенного элемента (так как последнее число и 'n'[0,1,...,n] чисел до него уже можно не сравнивать)
        //static int[] BubbleSort(int[] numbersArray, out int[] sortNumbersArray)
        static int[] BubbleSort(int[] numbersArray)
        {

            // Пример: { 9, 7, 5, 4, 2, 1 } - массив из 6-ти элементов
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                //for (int j = 0; numbersArray.Length - j - 1 > 0 ; j++)
                for (int j = 0; j < numbersArray.Length - i - 1; j++)
                {
                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        int tempElem = numbersArray[j + 1];
                        numbersArray[j + 1] = numbersArray[j];
                        numbersArray[j] = tempElem;
                    }
                }
            }

            // 1-ая итерация (должно быть 5 сравнений)
            // 0 - 9,7,5,4,2,1 j=0
            // 1 - 7,9,5,4,2,1 j=1
            // 2 - 7,5,9,4,2,1 j=2
            // 3 - 7,5,4,9,2,1 j=3
            // 4 - 7,5,4,2,9,1 j=4
            // 5 - 7,5,4,2,1,9 j=5

            // 2-ая итерация (должно быть 4 сравнения)
            // 0 - 7,5,4,2,1,9 j=0
            // 1 - 5,7,4,2,1,9 j=1
            // 2 - 5,4,7,2,1,9 j=2
            // 3 - 5,4,2,7,1,9 j=3
            // 4 - 5,4,2,1,7,9 j=4
            // 5 - 5,4,2,1,7,9 j=5 (уже лишнее сравнение, т.к. на предыдущей итерации наибольшее число переместилось на последнюю позицию)

            // 3-ья итерация (должно быть 3 сравнения)
            // 0 - 5,4,2,1,7,9 j=0
            // 1 - 4,5,2,1,7,9 j=1
            // 2 - 4,2,5,1,7,9 j=2
            // 3 - 4,2,1,5,7,9 j=3
            // 4 - 4,2,1,5,7,9 j=4 (лишняя итерация)
            // 5 - 4,2,1,5,7,9 j=5 (лишняя итерация)

            // 4-ая итерация (должно быть 2 сравнения)
            // 0 - 4,2,1,5,7,9 j=0
            // 1 - 2,4,1,5,7,9 j=1
            // 2 - 2,1,4,5,7,9 j=2
            // 3 - 2,1,4,5,7,9 j=3 (лишняя итерация)
            // 4 - 2,1,4,5,7,9 j=4 (лишняя итерация)
            // 5 - 2,1,4,5,7,9 j=5 (лишняя итерация)

            // 5-ая итерация (должно быть 1 сравнение)
            // 0 - 2,1,4,5,7,9 j=0
            // 1 - 1,2,4,5,7,9 j=1
            // 2 - 1,2,4,5,7,9 j=2 (лишняя итерация)
            // 3 - 1,2,4,5,7,9 j=3 (лишняя итерация)
            // 4 - 1,2,4,5,7,9 j=4 (лишняя итерация)
            // 5 - 1,2,4,5,7,9 j=5 (лишняя итерация)

            ///int[] array = { 1, 2, 3 };
            return numbersArray;
        }


        /*
        // Эта сортировка во внутреннем цикле будет всегда идти по всем элементам (а это лишние бесполезные проверки)
        static int[] BubbleSort(int[] numbersArray, out int[] sortNumbersArray)
        {

            // { 7, 5, 6, 3, 1, 4 } - массив из 6-ти элементов
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                //for (int j = 0; numbersArray.Length - j > 0 ; j++)
                for (int j = 0; j < numbersArray.Length - 1; j++) // numbersArray.Length = 6, т.е. j < 5
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
        */
    }
}
