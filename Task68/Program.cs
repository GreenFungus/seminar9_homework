// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Ack(m, n - 1);

        m -= 1;
    }
    return n + 1;
}

Console.WriteLine("Введите первое неотрицательное число m: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число n: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

if (mNumber < 0 || mNumber < 0) 
{
    Console.WriteLine("Не верный ввод!");
    return;
}

int ack = Ack(mNumber, nNumber);
Console.WriteLine($"m = {mNumber}, n = {nNumber} -> A(m, n) = {ack}");