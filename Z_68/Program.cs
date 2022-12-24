// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.Write("Введите целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akk(n, m));