class Program
{
    static void Main(string[] args)
    {
        #region SEMINAR

        #region Задача 53

        //**Задача 53:** Задайте двумерный массив.
        //Напишите программу, которая поменяет местами первую и последнюю строку массива.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //В итоге получается вот такой массив:
        //8 4 2 4
        //5 9 2 3
        //1 4 7 2

        //int[,] array =
        //{
        //    {1,2,3,4},
        //    {5,6,7,8},
        //    {9,10,11,12},
        //    {11,12,13,14}
        //};

        //int[,] newArray = array.Clone() as int[,];

        //int lastrowindex = array.GetLength(0) - 1;

        //for (int i = 0; i < array.GetLength(1); i++)
        //{
        //    newArray[0, i] = array[lastrowindex, i];
        //    newArray[lastrowindex, i] = array[0, i];
        //}

        //PrintArray(array);
        //PrintArray(newArray);
        #endregion

        #region Задача 55
        //**Задача 55:** Задайте двумерный массив.
        //Напишите программу, которая заменяет строки на столбцы.
        //В случае, если это невозможно, программа должна вывести сообщение для пользователя.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //5 2 6 7
        //В итоге получается вот такой массив:
        //1 5 8 5
        //4 9 4 2
        //7 2 2 6
        //2 3 4 7

        //int[,] array =
        //{
        //    {1, 2,  3,  4 },
        //    {5, 6,  7,  8 },
        //    {9, 10, 11, 12},
        //};

        //PrintArray(array);

        //int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

        //for (int i = 0; i < array.GetLength(0); i++)
        //{
        //    for (int j = 0; j < array.GetLength(1); j++)
        //    {
        //        newArray[j, i] = array[i, j];
        //    }
        //}

        //PrintArray(newArray);
        #endregion

        #region Задача 59
        //Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

        //int[,] array =
        //{
        //    { 1, 2, 52, 10 },
        //    { 5, 7, 11, 5 },
        //    { 34, 9, 0, 11 },
        //    { 3, 2, 9, 6 },
        //    { 13, 21, -9, -5 },
        //};

        //PrintArray(array);
        //FindMinimalIndex(array, out int minItemColumnIndex, out int minItemRowIndex);
        //array = RebuildArray(array, minItemColumnIndex, minItemRowIndex);
        //PrintArray(array);
        #endregion

        #region Задача 4
        //Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

        //int[,] array =
        //{
        //    { 1, 2, 52, 10 },
        //    { 5, 7, 11, 5 },
        //    { 34, 9, 0, 11 },
        //    { 3, 2, 9, 6 },
        //    { 13, 21, -9, -5 },
        //};
        //PrintArray(array);
        //SortOddColumns(array);
        //PrintArray(array);
        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 54
        //Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //В итоге получается вот такой массив:
        //7 4 2 1
        //9 5 3 2
        //8 4 4 2

        //int[,] array =
        //{
        //    {1,4,7,2},
        //    {5,9,0,3},
        //    {8,4,2,4},
        //};

        //array.Print();

        //array.SortArrayRow();

        //array.Print();

        #endregion

        #region Задача 56
        //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //5 2 6 7
        //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

        //int[,] array =
        //{
        //    { 5, 9, 2, 3 },
        //    { 8, 4, 2, 4 },
        //    { 9, 4, 5, 2 },
        //    { 5, 2, 6, 7 },
        //    { 3, 8, 1, 2 }
        //};

        //array.Print();

        //array.MinimalSumRowIndex();

        #endregion

        #region Задача 58
        //Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
        //Например, даны 2 матрицы:
        //2 4 | 3 4
        //3 2 | 3 3
        //Результирующая матрица будет:
        //18 20
        //15 18

        //Console.WriteLine("Матрица 1: ");
        //int[,] firstMatrix =
        //{
        //    { 2, 4, 2 },
        //    { 3, 2, 1 },
        //    { 4, 1, 0 },
        //};
        //firstMatrix.Print();
        //Console.WriteLine("Матрица 2: ");
        //int[,] secondMatrix =
        //{
        //    { 3, 4, 1 },
        //    { 3, 5, 7 },
        //    { 6, 1, 2 },
        //};
        //secondMatrix.Print();

        //if (firstMatrix.GetLength(0) == secondMatrix.GetLength(1) && firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
        //{
        //    var result = MultiplyMatrix(firstMatrix, secondMatrix);
        //    Console.WriteLine("Результат произведения: ");
        //    result.Print();
        //}
        //else
        //{
        //    Console.WriteLine("Нет возможности их перемножить.");
        //}

        #endregion

        #region Задача 60
        //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        //Массив размером 2 x 2 x 2
        //66(0, 0, 0) 25(0, 1, 0)
        //34(1, 0, 0) 41(1, 1, 0)
        //27(0, 0, 1) 90(0, 1, 1)
        //26(1, 0, 1) 55(1, 1, 1)

        //int[,,] array = GetEnumArray();
        //Console.WriteLine("Трехмерный массив из двузначных и не повторяющихся чисел: ");
        //array.Print();
        //Console.WriteLine("Задание 60: ");
        //array.PrintByLines();

        #endregion

        #region Задача 62
        //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
        //Например, на выходе получается вот такой массив:
        //01 02 03 04
        //12 13 14 05
        //11 16 15 06
        //10 09 08 07

        //Console.WriteLine("Введите размерность массива для спирального заполнения: ");
        //int.TryParse(Console.ReadLine(), out int X);
        //int[,] array = new int[X, X];
        //FillSpiralArray(array, array.GetLength(0), array.GetLength(1), 1, 0, 0);
        //Console.WriteLine("Спиральный массив: ");
        //array.Print();

        #endregion

        #endregion

    }
    static void FillSpiralArray(int[,] array, int stopLine, int stopColumn, int counter, int startColumn, int startLine)
    {
        if (counter <= array.GetLength(0) * array.GetLength(1))
        {
            for (int i = startColumn; i < stopColumn; i++)
            {
                array[startLine, i] = counter++;
            }
            for (int i = startLine + 1; i < stopLine; i++)
            {
                array[i, stopColumn - 1] = counter++;
            }
            for (int i = stopColumn - 2; i >= startColumn; i--)
            {
                array[stopLine - 1, i] = counter++;
            }
            for (int i = stopLine - 2; i >= startLine + 1; i--)
            {
                array[i, startLine] = counter++;
            }
            FillSpiralArray(array, stopLine - 1, stopColumn - 1, counter, startColumn + 1, startLine + 1);
        }
    }
    static void PrintArray(int[,] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void FindMinimalIndex(int[,] array, out int minItemColumnIndex, out int minItemRowIndex)
    {
        minItemColumnIndex = 0;
        minItemRowIndex = 0;
        int minNumber = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minNumber)
                {
                    minItemColumnIndex = j;
                    minItemRowIndex = i;
                    minNumber = array[i, j];
                }
            }
        }
    }
    static int[,] RebuildArray(int[,] array, int minItemColumnIndex, int minItemRowIndex)
    {
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        for (int ai = 0, nai = 0; ai < array.GetLength(0); ai++)
        {
            if (ai == minItemRowIndex)
                continue;

            for (int aj = 0, naj = 0; aj < array.GetLength(1); aj++)
            {
                if (aj == minItemColumnIndex)
                    continue;

                newArray[nai, naj] = array[ai, aj];
                naj++;
            }
            nai++;
        }
        return newArray;
    }
    static void SortOddColumns(int[,] array)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (column % 2 == 0)
                continue;

            int[] newArray = new int[array.GetLength(0)];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                newArray[row] = array[row, column];
            }

            Array.Sort(newArray);

            for (int row = 0; row < array.GetLength(0); row++)
            {
                array[row, column] = newArray[row];
            }
        }
    }
    static int[,] MultiplyMatrix(int[,] first, int[,] second)
    {
        int[,] result = new int[first.GetLength(0), first.GetLength(1)];

        for (int lines = 0; lines < result.GetLength(0); lines++)
        {
            for (int column = 0; column < result.GetLength(0); column++)
            {
                for (int numberIndex = 0; numberIndex < result.GetLength(0); numberIndex++)
                {
                    result[lines, column] += first[lines, numberIndex] * second[numberIndex, column];
                }
            }
        }

        return result;
    }
    static int[,,] GetEnumArray()
    {
        int[,,] array = new int[2, 2, 2];

        int[] numbers = Enumerable.Range(1, array.GetLength(0) * array.GetLength(1) * array.GetLength(2) + 1).ToArray();

        for (int rangeIndex = numbers.Length - 1, pages = 0; pages < array.GetLength(0); pages++)
        {
            for (int lines = 0; lines < array.GetLength(1); lines++)
            {
                for (int column = 0; column < array.GetLength(2); column++)
                {
                    array[pages, lines, column] = numbers[rangeIndex] * 10;
                    rangeIndex--;
                }
            }
        }


        return array;
    }
}
static class MyArrayExtention
{
    public static void Print(this int[,] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void PrintByLines(this int[,,] array)
    {
        Console.WriteLine();

        for (int pages = 0; pages < array.GetLength(0); pages++)
        {
            for (int lines = 0; lines < array.GetLength(1); lines++)
            {
                for (int column = 0; column < array.GetLength(2); column++)
                {
                    Console.Write($"{array[lines, column, pages]} ({lines}, {column}, {pages}) \t");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
    public static void Print(this int[,,] array)
    {
        Console.WriteLine();

        for (int pages = 0; pages < array.GetLength(0); pages++)
        {
            Console.Write($"Page {pages}: \n");
            for (int lines = 0; lines < array.GetLength(1); lines++)
            {
                for (int column = 0; column < array.GetLength(2); column++)
                {
                    Console.Write($"{array[pages, lines, column]} ({pages}, {lines}, {column}) \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void SortArrayRow(this int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {

            int[] newArray = new int[array.GetLength(1)];

            for (int column = 0; column < array.GetLength(1); column++)
            {
                newArray[column] = array[row, column];
            }

            Array.Sort(newArray);

            for (int column = 0; column < array.GetLength(1); column++)
            {
                array[row, column] = newArray[column];
            }
        }
    }
    public static void MinimalSumRowIndex(this int[,] array)
    {
        int minimalSumIndex = 0;

        int minimalSum = 0;

        for (int column = 0; column < array.GetLength(1); column++)
        {
            minimalSum += array[0, column];
            minimalSumIndex = 0;
        }

        for (int row = 0; row < array.GetLength(0); row++)
        {
            int sumOfRowNumbers = 0;

            for (int column = 0; column < array.GetLength(1); column++)
            {
                sumOfRowNumbers += array[row, column];
            }

            if (sumOfRowNumbers < minimalSum)
            {
                minimalSum = sumOfRowNumbers;
                minimalSumIndex = row;
            }
        }
        Console.WriteLine($"Найдена строка с минимальной суммой элементов. {minimalSumIndex + 1} строка с суммой {minimalSum}");
    }
}