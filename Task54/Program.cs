// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] SetArray2D(int line, int column)
{
    int[,] numArr2D = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D[i, j] = new Random().Next(0, 10);            // метод заполнения двумерного массива
        }
    }
    return numArr2D;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)               //  метод вывода двумерного массива
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArr2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int a = 0; a < array2D.GetLength(1); a++)         // метод замены местами первой и последней строки
            {
                if (array2D[i, a] < array2D[i, j])
                {
                    int temp = array2D[i, j];
                    array2D[i, j] = array2D[i, a];
                    array2D[i, a] = temp;
                }
            }
        }
    }
    return array2D;
}

int m = InputNum("Задайте кол-во строк: ");
int n = InputNum("Задайте кол-во столбцов: ");

int[,] array = SetArray2D(m, n);

Console.WriteLine($"Ваш массив :");
PrintArray2D(array);

int[,] sortArray = SortArr2D(array);

Console.WriteLine($"Ваш отсортированный массив:");
PrintArray2D(sortArray);