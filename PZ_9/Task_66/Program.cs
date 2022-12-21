Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
Summa(m, n, 0);
void Summa(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    Summa(m, n, sum);
}