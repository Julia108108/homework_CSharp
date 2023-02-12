// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 4;
int n = 4;
int[,] array = new int[m, n];

FillArraySpiral(array);
PrintArray(array);
//SortToLower(table);
//Console.WriteLine();
//PrintArray(table);

void FillArraySpiral(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] +  " "}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
