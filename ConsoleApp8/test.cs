using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp8
{
    class Test
    {

        public static List<int> GenerateNumbers(int elementsCount)
        {
            Random random = new System.Random();
            List<int> resultList = new List<int>();

            if (elementsCount > 0)
            {
                for (int i = 0; i < elementsCount; i++)
                {
                    int num = random.Next(-10, 10);
                    resultList.Add(num);
                }
            }

            return resultList;
        }
        public static int SumOfNumbers(int firstIndex, int lastIndex, List<int> list)
        {
            int sumOfNumbers = 0;
            string s = "";
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                sumOfNumbers += list[i-1];
            }

            Console.WriteLine(s);
            return sumOfNumbers;
        }
        //public static void Test1(List<int> list)
        //{
        //    int sumOfNumbers = 0;
        //    foreach (var element in list)
        //        Program.addNumberToList(element);

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Random random = new System.Random();
        //        int firstIndex_param = random.Next(1, 5);
        //        int lastIndex_param = random.Next(5, list.Count);
        //        sumOfNumbers = SumOfNumbers(firstIndex_param, lastIndex_param, list);
        //        Console.WriteLine("A[{0}][{1}] = {2}    {3}", firstIndex_param, lastIndex_param, sumOfNumbers, Program.addSumNumbersToList_n(firstIndex_param, lastIndex_param));
        //    }
        //        Console.WriteLine("A[{0}][{1}] = {2}    {3}", 2, 2, SumOfNumbers(2, 2, list), Program.addSumNumbersToList_n(2, 2));
        //        Console.WriteLine("A[{0}][{1}] = {2}    {3}", 3, 3, SumOfNumbers(3, 3, list), Program.addSumNumbersToList_n(3, 3));
        //        Console.WriteLine("A[{0}][{1}] = {2}    {3}", 4, 5, SumOfNumbers(4, 5, list), Program.addSumNumbersToList_n(4, 5));
        //}

    }
}
