// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] SpiralArray(int side)
{
    int number = 1;
    int i = 0;
    int j = 0;
    int[,] spiralArr = new int[side, side];
    while (number <= side * side)
    {
        spiralArr[i, j] = number++;
        if (i <= j + 1 && i + j < side - 1)
            j++;
        else if (i < j && i + j >= side - 1)              // метод спирального заполнения массива
            i++;
        else if (i >= j && i + j > side - 1)
            j--;
        else
            i--;
    }
    return spiralArr;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] < 10) 
                Console.Write($"0{array2D[i, j]} ");            // метод вывода двумерного массива
            else
                Console.Write($"{array2D[i, j]} ");            
        }
        Console.WriteLine();
    }
}

int n = InputNum("Задайте сторону массива : ");

int[,] array = SpiralArray(n);

Console.WriteLine($"Спиральный массив :");
PrintArray2D(array);