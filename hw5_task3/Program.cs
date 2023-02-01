//Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

System.Console.Write("Размер массива --> ");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = new double[len];
Random rnd = new Random();

FillRandomArray(array, len);
PrintArray(array, len);
ArrayMinMax(array, out double min, out double max);
Console.WriteLine($ Max element; {max} min element: {min}"");
Console.WriteLine($"Разница между макс и минэл: {max-min}");

на тел продолжение кода