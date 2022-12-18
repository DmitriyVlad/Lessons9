// Задача 64. Вывести натуральные числа от N до 1 с помощью рекурсии

Console.Write("Введите натуральное число больше 1: ");
int number = int.Parse(Console.ReadLine());

void NumberCounter (int number)
{
    if (number == 0) return;
    Console.Write($"{number} ");
    NumberCounter (number - 1);
}

NumberCounter(number);

Console.WriteLine();
