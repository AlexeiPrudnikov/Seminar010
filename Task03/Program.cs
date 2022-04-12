List<int> GetSimpleNumbers(int number)
{
    List<int> numbers = new List<int>();
    bool simple;
    for (int i = 2; i <= number; i++)
    {
        simple = true;
        for (int z = 2; z <= (int)System.Math.Sqrt(i); z++)
        {
            if ((i % z) == 0)
            {
                simple = false;
                break;
            }
        }
        if (simple) numbers.Add(i);
    }
    return numbers;
}
void GetSimpleDivisors(int number)
{
    List<int> simpleNumbers = GetSimpleNumbers(number);
    foreach (int i in simpleNumbers)
    {
        if (number % i == 0)
        {
            Console.Write(i + " ");
            GetSimpleDivisors(number / i);
            return;
        }
    }
}
Console.Clear();
Console.WriteLine("==========Задача № 3==========");
Console.WriteLine("Дано натульное число n > 1. Вывести все простые множители данного числа.");
int number = 720;
Console.Write(number + " -> ");
GetSimpleDivisors(number);
Console.WriteLine();
