﻿/*
Задача 52: 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Метод для создания массива
// Двумерный массив = matrix
// m - количество строчек, n - количество столбцов

Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int maxElements = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = GetMatrix(rows, columns, minElements, maxElements);

// rows = 3 columns = 4 => таблица из 3-х строк и 4 -х столбцов, элемент: число от min до max включительно
Console.WriteLine();
PrintMatrix(resMatrix); // PrintMatrix(матрица)
Console.WriteLine();

MeanArithmeticColumn(resMatrix);

int[,] GetMatrix(int m, int n, int minElements, int maxElements)
{
    int[,] matrix = new int[m,n]; // Таблица из m - строк и n - столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам, i < m
    {
       // i, j, m, k
       for (int j = 0; j < matrix.GetLength(1); j++) // Цикл по столбцам, j < n
       {
        matrix[i, j] = new Random().Next(minElements, maxElements+1);
       } 
    }
    return matrix;
}
// Метод, который печатает массив
void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
        Console.Write(array2D[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
       } 
       Console.WriteLine();
    }

}
// Метод, который находит находит среднее арифметическое элементов в каждом столбце.


void MeanArithmeticColumn(int[,] array2D)
{
    
    for (int i = 0; i < array2D.GetLength(1); i++) // строчки
    {
        double sum = 0; // Среднее арифметическое
       for (int j = 0; j < array2D.GetLength(0); j++) // столбцы
       {
        
        sum = sum + array2D [j,i]; // Находим сумму строчки
       } 
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {sum / array2D.GetLength(0)}");

    }
} 

