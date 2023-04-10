// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма в промежутке от M до N равна {PrintNumbers(M, N)}");

int PrintNumbers(int M, int N)
{
    if (M == N) return N;
    return M + PrintNumbers(M + 1, N);
}
