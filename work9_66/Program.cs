// Задача 66. Найти сумму натуральных чисел от m до n методом рекурсии

Console.Write("Введите первое натуральное число больше 1: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе натуральное число больше 1: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write("Сумма натуральных чисел от " + m + " до " + n + " равна " + RecursMetod(m, n, sum));

static int RecursMetod(int m, int n, int sum)
{
    if (m <= n)
    {
        sum = sum + m;
        m++;
        return
        RecursMetod(m, n, sum);
    }
    Console.WriteLine();
    return sum;
}
Console.WriteLine();