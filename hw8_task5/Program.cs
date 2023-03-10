// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[length, length];

int num = 1;
int i = 0;
int j = 0;

while (num <= length * length)
{
    table[i, j] = num;
    if (i <= j + 1 && i + j < length - 1)
        ++j;
    else if (i < j && i + j >= length - 1)
        ++i;
    else if (i >= j && i + j > length - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(table);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}


