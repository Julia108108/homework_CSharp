// Задача 60.Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Решение: как проверить непотворяющ эл-ми? 3 перемноженных измерения должны быть меньше 90. 
// У нас 90 неповторяющихся эл-ов. 
// вар1. можно сгенерировать, а потом проверять, но это сложнее
// вар2. можно заранее взять известные числа, их перемешать и порядку их складывать в массив спиральным методом
// if else и 4 направления. понимаем в какую сторону движемся и из-за этого увелич или уменьш тот или иной индекс

Console.WriteLine("Напишите количество переменных первой оси: ");
int i = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Напишите количество переменных второй оси: ");
int j = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Напишите количество переменных третьей оси: ");
int k = Convert.ToInt32 (Console.ReadLine());
int[,,] array = new int[i, j, k];
//int[ ] arrayInputNumbers =  new int ();
FillArray(array);
Print(array);
Console.WriteLine();
StringWithIndex(array);

void FillArray(int[,,] array)
{
    //Random rnd = new Random();
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            array [i, j, k] = count;
            count = count + 3;
        }
    }
}

void Print(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i, j, k] +  " "}"); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void StringWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
        }
    }
}
