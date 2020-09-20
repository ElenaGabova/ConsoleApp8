using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp8
{

    class Program
    {
        public static int[] sumNumbersList = new List<int>();
        public static int[] outputList = new List<int>();
        public static string sumNumbers = "";
        static int Main(string[] args)
        {
            ReadFromConsole();
            return 0;

        }

        public static void ReadFromConsole()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            string line;
            int firstIndex;
            int LastIndex;

            for (int i = 0; i < numbersCount; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                addNumberToList(inputNumber);
            }

            int numbersDistanceCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersDistanceCount; i++)
            {
                line = Console.ReadLine();
                int indexOfSpace = line.IndexOf(' ');

                firstIndex = int.Parse(line.Substring(0, indexOfSpace));
                LastIndex  = int.Parse(line.Substring(indexOfSpace + 1));
                addSumNumbersToList(firstIndex, LastIndex);
            }
            Console.WriteLine(sumNumbers.Substring(0, sumNumbers.Length -1));
        }

        public static void addNumberToList(int inputNumber)
        {
            int listLength = sumNumbersList.Count;
            int sumOfElements = inputNumber;
            sumNumbersList[0] = 0;
            if (listLength >= 1)
                sumOfElements += sumNumbersList[listLength - 1];

            sumNumbersList.Add(sumOfElements);
        }

        public static void addSumNumbersToList(int firstIndex, int lastIndex)
        {
            int result = 0;

            if (firstIndex == 1)
                result = sumNumbersList[lastIndex - 1];

            if (result.Equals(0))
                result = sumNumbersList[lastIndex - 1] - sumNumbersList[firstIndex - 2];
            sumNumbers += result + "\n";
        }
    }
}
