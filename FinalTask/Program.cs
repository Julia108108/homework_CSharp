// Итоговая проверочная работа: написать программу, которая из имеющегося массива из строк
// формирует массив из строк, длина которых менее или равна 3 символа. Первоначальный массив
// можно ввести с клавиатуры, либо  задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться  коллекциями, лучше обойтись массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

string[] arrayInput = new string [7] { "my", "dear", "let", "us", "go", "to", "cinema" };
string[] arrayResult = new string[arrayInput.Length];

SecondArrayWithIf(arrayInput, arrayResult);
PrintArray(arrayResult);


void SecondArrayWithIf(string[] arrayInput, string[] arrayResult)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i].Length <=3)
        {
            arrayResult[count] = arrayInput[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
