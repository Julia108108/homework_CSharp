// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] arrayFirst = new int[2, 2];
int[,] arraySecond = new int[2, 2];
FillArrayByRandom(arrayFirst);
FillArrayByRandom(arraySecond);
Print(arrayFirst);
Print(arraySecond);
Print(Multiply(arrayFirst, arraySecond));


void FillArrayByRandom(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++) //
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(1, 10);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] +  " "}"); //выводит
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multiply(int[,] arrayFirst, int[,] arraySecond) //возвращаемый тип, название
{
    int[,] resultArray = new int[2, 2]; 
    if (arrayFirst.GetLength(0) != arraySecond.GetLength(1))
    {
        Console.WriteLine("Подобные матрицы нельзя перемножить");
    }
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                resultArray[i, j] = resultArray[i, j] + arrayFirst[i, k] * arraySecond[k, j];

            }
        }
    }
    return resultArray;
}