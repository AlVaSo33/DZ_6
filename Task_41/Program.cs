// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine()!);

int CountPositiveNumbers()
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int input = int.Parse(Console.ReadLine()!);
        if (input > 0) count++;
    }
    return count;
}
int result = CountPositiveNumbers();
Console.WriteLine("Количество положительных чисел: " + result);