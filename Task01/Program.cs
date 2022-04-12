void ReverseNumber(int number)
{
    if (number == 0) return;
    int div = number / 10;
    int mod = number % 10;
    Console.Write(mod);
    ReverseNumber(div);
}

Console.Clear();
Console.WriteLine("==========Задача № 1==========");
Console.WriteLine("Дано число n. Получите число, записанное в обратном порядке.");
int number = 14235;
Console.Write(number + " -> ");
ReverseNumber(number);
Console.WriteLine();
