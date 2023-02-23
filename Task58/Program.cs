// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());       // метод для ввода числа пользователем
}

int[,] SetArray2D(int line, int column)
{
    int[,] numArr2D = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D[i, j] = new Random().Next(0, 10);    // метод заполнения двумерного массива
        }
    }
    return numArr2D;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)     // метод вывода двумерного массива
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] multArray(int[,] arrayA, int[,] arrayB)            // произведения двух матриц
{
    int lineC, columnC;
    if (arrayA.GetLength(0) > arrayB.GetLength(0))
    {
        lineC = arrayB.GetLength(0);
    }
    else
    {
        lineC = arrayA.GetLength(0);
    }

    if (arrayA.GetLength(1) > arrayB.GetLength(1))         // размерность матрицы
    {
        columnC = arrayB.GetLength(1);
    }
    else
    {
        columnC = arrayA.GetLength(1);
    }

    int[,] arrayC = new int[lineC, columnC];

    // Перемножаем матрицы

    for (int i = 0; i < lineC; i++)
    {
        for (int j = 0; j < columnC; j++)
        {
            for (int e = 0; e < lineC; e++)
            {
                arrayC[i, j] += arrayA[i, e] * arrayB[e, j];           // Перемножаем матрицы
            }
        }
    }
    return arrayC;
}

int mA = InputNum("Задайте кол-во строк матрицы A: ");
int nA = InputNum("Задайте кол-во столбцов матрицы A: ");

int[,] arrayA = SetArray2D(mA, nA);

int mB = InputNum("Задайте кол-во строк матрицы B: ");
int nB = InputNum("Задайте кол-во столбцов матрицы B: ");

int[,] arrayB = SetArray2D(mB, nB);

Console.WriteLine($"Матрица A:");
PrintArray2D(arrayA);

Console.WriteLine($"Матрица B:");
PrintArray2D(arrayB);

int[,] arrayC = multArray(arrayA, arrayB);

Console.WriteLine($"Матрица A*B:");
PrintArray2D(arrayC);