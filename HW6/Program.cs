using System;
using System.Collections.Generic;

namespace HW7
{
    class Program
    {
        static int[,] GetIntMatrix(int rows, int columns)
        {
            var random = new Random();
            var twoDimensionalArray = new int[rows, columns];
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = random.Next(0, 10);
                    Console.Write($"{twoDimensionalArray[i, j]} ");
                }
                Console.WriteLine();
            }

            return twoDimensionalArray;

        }

        static int[,] FirstTask()
        {
            var array = GetIntMatrix(5, 4);
            for (var row = 0; row < array.GetLength(0); row++)
                for (var element = 0; element < array.GetLength(1); element++)
                    for (var column = element + 1; column < array.GetLength(1); column++) 
                    {
                        if (array[row, element] < array[row, column])
                        {
                            var temp = array[row, column];
                            array[row, column] = array[row, element];
                            array[row, element] = temp;
                        }
                    }
            return array;
        }

        static void SecondTask()
        {
            var array = GetIntMatrix(5, 5);
            var min_sum = 0;
            var row_number = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    sum += array[i, j];
                if (i == 0)
                    min_sum = sum;
                if (min_sum > sum)
                {
                    min_sum = sum;
                    row_number = i;
                }
                Console.WriteLine($"Строка {i}: Сумма {sum}");
            }

            Console.WriteLine($"Строка с минимальной суммой под индексом {row_number}");

        }

        static void ThirdTask() 
        {
            var first_matrix = GetIntMatrix(2, 2);
            var second_matrix = GetIntMatrix(2, 2);
            var result_matrix = new int[2, 2];

            for (int i = 0; i < first_matrix.GetLength(0); i++)
                for (int j = 0; j < second_matrix.GetLength(0); j++)
                    for (int k = 0; k < second_matrix.GetLength(0); k++)
                        result_matrix[i, j] += first_matrix[i, k] * second_matrix[k, j];

        }

        static int GetRandomNumber(List<int> gen_numbers) 
        {
            var random = new Random();
            var random_number = random.Next(0, 100);
            while (gen_numbers.Contains(random_number)) 
                random_number = random.Next();
            return random_number; 
        }

        static void FourthTask() 
        {
            
            var gen_numbers = new List<int>();
            var cube = new int[2, 2, 2];
            for (var x = 0; x < cube.GetLength(0); x++)
            {
                for (var y = 0; y < cube.GetLength(0); y++)
                    for (var z = 0; z < cube.GetLength(0); z++)
                    {

                        var random_number = GetRandomNumber(gen_numbers);
                        gen_numbers.Add(random_number);
                        cube[x, y, z] = random_number;
                        Console.Write($"{cube[x, y, z]} ({x}, {y}, {z}) ");
                    }
                Console.WriteLine();
            }
                
        }

        static void Main(string[] args)
        {
            FirstTask();
            SecondTask(); 
            ThirdTask();
            FourthTask();
        }
               
    }
}