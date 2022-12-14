// Задача 47.  Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 9 -9
// 8 7 -7 9

// Console.WriteLine("Введите количество строк");
// int row = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов");
// int column = int.Parse(Console.ReadLine()!);

// PrintArray(GetArray(row, column, -99, 99));

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
	return array;
}

void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
        	Console.WriteLine();
        }
	}

// Задача 50. Напишите программу, которая на вход принимает позиции элементов в двумерном массиве, и возвращает значение этого элементов или же указание, что такого элемента нет.
// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4 j = 2 → такого числа нет в массиве
// i = 1, j = 2 → 2

// Console.WriteLine("Ввелите позицию строки"");
// int i = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите позицию столбца");
// int j = int.Parse(Console.ReadLine()!);
// int row = 3;
// int column = 4;
// int[,] array1 = GetArray(row, column, 0, 9);
// PrintArray(array1);
// if ((i >= 0 && i <= row) && (j >= 0 && j <= column)) Console.WriteLine($"{array1[i, j]}");
// else Console.WriteLine("Такого числа нет");

// Задача 52. Задайте двумерный массив из целых числе. Найтиде среднее арифметическое элементов в каждом стольбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца; 4,6; 5,6; 3.

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int column = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(row, column, 1, 9);
PrintArray(array2);

for (int j = 0; j < array2.GetLength(1); j++)
{
    double sum = 0;
    double count = 0;
    double result = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        sum += array2[i, j];
        count++;
    if(count == array2.GetLength(0)){
        result = sum / count;
        Console.Write("{0:F1}|", result);
    }
    }
}


