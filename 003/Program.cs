/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FuctionAccerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0)
    {
        return FuctionAccerman(m - 1, 1);
    }
    return FuctionAccerman(m - 1, FuctionAccerman(m, n - 1));
}
Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} -> {FuctionAccerman(m, n)}");