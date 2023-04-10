// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"Функция Аккермана = {PrintNumbers(M, N)}");

int PrintNumbers(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return PrintNumbers(M - 1, 1);
    return PrintNumbers(M - 1, PrintNumbers(M, N - 1));
}
