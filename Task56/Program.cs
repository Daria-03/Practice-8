// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());          // метод для ввода числа пользователем
}

int[,] SetArray2D(int line, int column)
{
    int[,] numArr2D = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D[i, j] = new Random().Next(0, 10);     // метод заполнения двумерного массива
        }
    }
    return numArr2D;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)        // метод вывода двумерного массива
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumLineArr2D(int[,] array2D)
{
    int[] sumArr = new int[array2D.GetLength(0)];
    Console.Write($"Суммы строк:");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)       // метод поиска строки с наименьшей суммой элементов
        {
            sumArr[i] += array2D[i, j];
        }
        Console.Write($" {sumArr[i]}");
    }
    Console.WriteLine();
    int minSum = sumArr[0];
    int minLine = 1;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minLine = i + 1;
        }
    }
    return minLine;
}

int m = InputNum("Задайте кол-во строк: ");
int n = InputNum("Задайте кол-во столбцов: ");

int[,] array = SetArray2D(m, n);

Console.WriteLine($"Ваш массив :");
PrintArray2D(array);

int line = SumLineArr2D(array);

Console.WriteLine($"Наименьшая сумма элементов в {line} строке");