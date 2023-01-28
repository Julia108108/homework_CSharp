// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//не знаем длину числа.
//можно математически оперировать числами
//через сроки также можно решить и не конвертировать. это проще

//System.Console.Write ("Введите число: ");

Random rnd = new Random();
int a = rnd.Next();

System.Console.WriteLine($"Число {a}");

int firstNumber = a / 100;
int lastNumber = a % 10;

a = firstNumber * 10 + lastNumber;

System.Console.WriteLine (a);

//if (a < 100)
//{
//    System.Console.WriteLine("Увы, в числе отсутствует третья цифра");
//}

//else
//{
//    int b = a % 10;
//    System.Console.WriteLine (b);
//}

