/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNaturalValue(int M, int N)
{
    if (M > N)
    {
        if (M == N) return M;
        return M + SumNaturalValue(M - 1, N);
    }
    if (M == N) return N;
    return N + SumNaturalValue(N - 1, M);

}
Console.WriteLine($"Сумма натуральных чисел от {N} до {M} -> {SumNaturalValue(M, N)}");