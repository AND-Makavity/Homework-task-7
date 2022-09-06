/*Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Write($"Введите количество строк в массиве: ");
int.TryParse(Console.ReadLine(), out int m);
Console.Write($"Введите количество столбцов в массиве: ");
int.TryParse(Console.ReadLine(), out int n);
float[,] arrayFloat = new float[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        int intA = new Random().Next(-99, 100);
        arrayFloat[i, j] = (float)intA / 10;
        Console.Write($"{arrayFloat[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


void FindElement(float[,] _array, int str, int row)
{
    if (str < _array.GetLength(0) && row < _array.GetLength(1))
        Console.WriteLine($"Значение элемента с индексом {str},{row} в массиве равно: {_array[str, row]}");
    else Console.WriteLine($"такого числа в массиве нет");
    Console.WriteLine();
}

FindElement(arrayFloat, 0, 0);


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void FindMeanOfRow(int[,] _array)
{
    Console.WriteLine("Среднее арифметическое элементов каждого столбца массива:");
    for (int j = 0; j < _array.GetLength(1); j++)
    {
        int i = 0;
        float mean = 0;
        while (i < _array.GetLength(0))
        {
            mean += _array[i, j];
            Console.Write($"{_array[i, j]} ");
            i++;
        }
        Console.WriteLine($" -> {(float)mean / i} ");
    }
}

FindMeanOfRow(array);