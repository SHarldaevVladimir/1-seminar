// 
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница


Console.WriteLine("Введите цифру от 1 до 7");
int input = int.Parse(Console.ReadLine()!);
if (input==1)
Console.WriteLine("Понедельник");

if (input==2)
Console.WriteLine("Вторник");
if (input==3)
Console.WriteLine("Среда");
if (input==4)
Console.WriteLine("Четверг");
if (input==5)
Console.WriteLine("Пятница");
if (input==6)
Console.WriteLine("Суббота");
if (input==7)
Console.WriteLine("Воскресение");




