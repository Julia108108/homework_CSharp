// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//switch case попробовать, на 1 семинале была
//сначла через esle ifб потмо switch case

System.Console.Write("Введите день недели соответствующей цифрой (1-7): ");
int a = Convert.ToInt32(Console.ReadLine());


switch (a)
{

case 1:
System.Console.WriteLine ("не выходной");
break;

case 2:
System.Console.WriteLine ("не выходной");
break;

case 3:
System.Console.WriteLine ("не выходной");
break;

case 4:
System.Console.WriteLine ("не выходной");
break;

case 5:
System.Console.WriteLine ("не выходной");
break;

case 6:
System.Console.WriteLine ("выходной");
break;

case 7:
System.Console.WriteLine ("выходной");
break;

default:
System.Console.WriteLine("Введите число");
break;




}