int GetSequenceValue(int number)
{
    return Convert.ToInt32(Math.Round((-1 + Math.Sqrt(-1 + 8 * number) / 2), 0) + 1);
}
Console.Clear();
Console.WriteLine("==========Задача № 2==========");
Console.WriteLine("Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: " +
                    "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности");
int count = 13;
Console.Write(count + " -> ");
for (int i = 1; i <= count; i++)
{
    Console.Write(GetSequenceValue(i) + " ");
}
Console.WriteLine();