// Напишите число умноженное само на себя
// пример: 4->16
//-3->9
//-7->49
Console.WriteLine("Программа вычисления квадрата числа");
Console.WriteLine("Введите число");
//1. ВВод числа
int input = int.Parse(Console.ReadLine()!);
//2. вычисление квадрата числа
int result = input * input;

//3. Вывод результата на консоль
Console.WriteLine("Квадрат числа " + result);
//
//Console.Writeline("Hello, world")
//op
