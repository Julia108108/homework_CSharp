// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

int[] arr = new int[8];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100,100);
}

foreach (var item in arr)
{
    System.Console.Write(item + " ");
}

bool f (int x)
{
    return (x > 0);
}

System.Console.WriteLine("\n" + arr.Count(f));

//Можно на строке 39 вместо f вставить лямбду и получится 
// System.Console.WriteLine("\n" + arr.Count( x >= x >0)); 

//Решение № 1 с лямбда функцией

//Console.Write("Введите элементы (через пробел): ");
//int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Array.ConvertAll - вот этой функции мы передали первым параметром на вход массивConsole.ReadLine - это строка, Split(",") - это массив. Вся эта строка - подали на вход массив строк, на выходе получили массив интов. Int.Parse - это "что нам нужно делать с массивом"
//int count = arr.Count(x => x > 0);  // это анонимная лямбда функция (x => x > 0). Если ей на вход поступил x, если x >0, то возвращаем x. Если x условие не удовлетворяет, то функция ничего не возвращает. То есть мы будем счиатьь только те x, которые больше 0
//Console.WriteLine($"Кол-во элементов > 0: {count}");

// эта анонимная функция будет делать вот это:
// bool f(int x)
// {
//      return(x>0);
//}

//Решение №2:

//int[] arr = new int[8];

//Random rnd = new Random();

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = rnd.Next(-100,100);
//}

//foreach (var item in arr)
//{
//    System.Console.Write(item + " ");
//}

//bool f (int x)
//{
//    return (x > 0);
//}

//System.Console.WriteLine("\n" + arr.Count(f));

//Можно на строке 39 вместо f вставить лямбду и получится 
// System.Console.WriteLine("\n" + arr.Count( x >= x >0)); 

//Решение №3

//Console.WriteLine("Enter an array of integer elements separated by Space, slash, dot or comma, and press 'enter'");
//string str = Console.ReadLine();
//char [] separator = new char [] {' ', ' '  / };
//string [] array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries); // благодаря StringSplitOptions.RemoveEmptyEntries работает с любыми знаками при введение чисел
//int [] a = Array.ConvertAll(array, intParse);
//Console.WriteLine("Your array: ");
//Console.Write("{"+string.Join(",",a)+"}"); // с пом. string.Join одной строчкой выводится весь массив

//int count = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    if(a[i]>0)count++;
//}
//Console.WriteLine("\nThe number of positive array elements is: ");
//Console.WriteLine(count);