// Задача 68. Вычисление функции Аккермана

Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

static int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine("Значение функции Аккермана = " + Akkerman(n, m));
