// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());     // метод для ввода числа пользователем
}

int[,,] SetArray3DRandom(int row, int line, int column)     // заполнение трехмерного массива неповторяющимися числами
{
    int start = 10;
    int[] number = new int[90];
    for (int i = 0; i < 90; i++)             // одномерный массив и с числами от 10 до 99 
    {
        number[i] = start++;
    }
    for (int i = 0; i < 90; i++)
    {
        int idx = new Random().Next(0, 90);
        int tempNmr = number[idx];             // Перемешиваем одномерный массив
        number[idx] = number[i];
        number[i] = tempNmr;
    }
    int nbrIdx = 0;
    int[,,] numArr3D = new int[row, line, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < line; j++)
        {
            for (int k = 0; k < column; k++)
            {
                numArr3D[i, j, k] = number[nbrIdx++];       // Заполняем трехмерный массив числами из перемешанного одномерного массива
            }
        }
    }
    return numArr3D;
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");   // метод вывода трехмерного массива с индексами
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int k = InputNum("Задайте кол-во рядов массива: ");
int m = InputNum("Задайте кол-во строк массива: ");
int n = InputNum("Задайте кол-во столбцов массива: ");
Console.WriteLine();

int[,,] array3D = SetArray3DRandom(k, m, n);

Console.WriteLine($"Массив с индексами элементов:");
PrintArray3D(array3D);