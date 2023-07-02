Console.Clear();
Random rnd = new Random();

double[,] CreateDoubleArray(int width, int height)
{
    double[,] tempBuf = new double[width, height];
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            tempBuf[i, j] = Math.Round(rnd.Next(-9, 10) + rnd.NextDouble(), 1);
        }
    }
    return tempBuf;
}

void PrintDoubleArray(double[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateIntArray(int width, int height)
{
    int[,] tempBuf = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            tempBuf[i, j] = rnd.Next(0, 10);
        }
    }
    return tempBuf;
}

int FindElement(int[,] array, int posX, int posY)
{
    int height = array.GetLength(0) - 1;
    if (posY > height) return -1;

    int width = array.GetLength(1) - 1;
    if (posX > width) return -1;

    if (posX == width || posY == height) return -2;

    return array[posX, posY];
}

void PrintIntArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void CheckAnswer(int answer)
{
    System.Console.WriteLine();
    if (answer == -1)
    {
        System.Console.Write("-> такого числа в массиве нет");
    }
    else if (answer == -2)
    {
        System.Console.WriteLine("Ты вышел за пределы, массивы с 0 начинаются.");
        System.Console.WriteLine($"Самый первый элемент массива с координатами (0,0) !");
    }
    else
    {
        System.Console.Write($"Ответ -> {answer}");
    }
    System.Console.WriteLine();
}

double[] CalculateRow(int[,] array)
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    double[] middleArifm = new double[width];
    int sum = 0;
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            sum += array[j, i];
        }
        middleArifm[i] = Math.Round((double)sum / height, 2);
        sum = 0;
    }
    return middleArifm;
}

Console.Clear();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// System.Console.Write("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = CreateDoubleArray(m, n);
// PrintDoubleArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// System.Console.Write("Введите ширину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите высоту массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateIntArray(m, n);
// PrintIntArray(array);
// System.Console.Write("Введите строку искомого элемента: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите столбец искомого элемента: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int answer = FindElement(array, x, y);
// CheckAnswer(answer);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.Write("Введите ширину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите высоту массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateIntArray(m, n);
PrintIntArray(array);
double[] answer = CalculateRow(array);
System.Console.Write($"Среднее арифметическое каждого столбца: {String.Join("; ", answer)}");