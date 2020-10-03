using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Menu();
            Console.ReadKey();
        }
         void  Menu()
        {
            Console.WriteLine("1) Reverse String\n2) Remove Duplicate\n3) Bubble Sort\n4) Binary Search\n5) Number frequency\n6) Check If Prime");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    ReverseString("Hello world");
                    break;
                case "2":
                    RemoveDuplicate("Hello world");
                    break;
                case "3":
                    List<int> numbers = new List<int>() { 1, 45, 3, 76, 100, 2, 90 };
                    BubbleSort(numbers);
                    break;
                case "4":
                    BinarySearch();
                    break;
                case "5":
                    FrequencyAppears();
                    break;
                case "6":
                    CheckIfPrimeNumber(23);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Menu();
        }
        void ReverseString(string input)
        {
            string reversedString = string.Empty;
            for (int i = input.Length - 1; i > -1; i--)
            {
                reversedString += input[i];
            }
            Console.WriteLine(reversedString);
        }
        void RemoveDuplicate(string input)
        {
            string nonDuplicateString = string.Empty;
            foreach(char character in input)
            {
                if (!nonDuplicateString.Contains(character))
                {
                    nonDuplicateString += character;
                }
            }
            Console.WriteLine(nonDuplicateString);
        }
        void BubbleSort(List<int> unOrdered)
        {
            int tempHolder;
            for (int i = 0; i < unOrdered.Count-1; i++)
            {
                for (int c = 0; c < unOrdered.Count-1; c++)
                {
                    if (unOrdered[c] > unOrdered[c + 1])
                    {
                        tempHolder = unOrdered[c];
                        unOrdered[c] = unOrdered[c + 1];
                        unOrdered[c + 1] = tempHolder;
                    }
                }
            }
            foreach(int number in unOrdered)
            {
                Console.Write(number+" ");
            }
        }
        void BinarySearch()
        {
            List<int> numbers = new List<int>() { 1, 2, 6, 12, 22, 60, 90 };
            int minNumber = 0;
            int maxNumber = numbers.Count - 1;
            int numberToFind = 22;
            while (minNumber <= maxNumber)
            {
                int middle = (minNumber + maxNumber) / 2;
                if (numberToFind == numbers[middle])
                {
                    Console.WriteLine(numbers[middle]);
                    return;
                }
                else if(numberToFind> numbers[middle])
                {
                    minNumber = middle + 1;
                }
                else
                {
                    maxNumber = middle - 1;
                }
            }
            Console.WriteLine("Not found");
            return;
        }
        void FrequencyAppears()
        {
            List<int> numbers = new List<int>() { 1,1,2, 6, 12,12,12, 22, 60, 90,90 };
            var freq = from x in numbers group x by x into y select y;
            foreach (var number in freq) 
            {
                Console.WriteLine($"Number:{number.Key} appears {number.Count()} times.");
            }
        }
        void CheckIfPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
            return;
        }

    }
}
