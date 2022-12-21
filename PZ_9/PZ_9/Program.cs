Console.WriteLine("Введите натуральное число:");
int chislo = int.Parse(Console.ReadLine());
if (chislo < 0) { Console.Write($"{chislo} не натуральное число"); }
else { Counter(chislo); }
void Counter(int chislo)
{
    if (chislo == 0) return;
    Console.Write($"{chislo} ");
    Counter(chislo - 1);
}