// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumNaturalItems(int start, int stop)
{
    if (start > stop) return 0;
    return start + GetSumNaturalItems(start + 1, stop);
}

Console.WriteLine("Введите начало диапазона: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона: ");
int stopNumber = Convert.ToInt32(Console.ReadLine());

if (startNumber < 1 || stopNumber < 1) 
{
    Console.WriteLine("Не верный ввод!");
    return;
}

int sum = 0;
if (startNumber > stopNumber) sum = GetSumNaturalItems(stopNumber, startNumber);
else sum = GetSumNaturalItems(startNumber, stopNumber);

Console.WriteLine($"M = {startNumber}; N = {stopNumber} -> {sum}");