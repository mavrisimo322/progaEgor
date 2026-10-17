using System;
int n;
while(true)
{
    Console.Write("ВВедите число студентов (1...50): ");
    string s = Console.ReadLine();
    if (int.TryParse(s, out n) && n >= 1 && n <=50)
    {
        break;
    }
    Console.WriteLine("Ошибка! Введите число от 1 до 50.");
}
int[] scores = new int [n];
for (int i = 0; i < n; i++)
{
    while (true)
    {
        Console.Write("Балл студента " + "(0...100): ");
        string s = Console.ReadLine();
        int x;
        if (int.TryParse(s, out x) && x >= 0 && x <= 100)
        {
            scores[i] = x;
            break;
        }
                Console.WriteLine("Ошибка! Введите целое число от 0 до 100.");
    }
}
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum = sum + scores[i];
}
double avg = (double)sum / n;
Console.WriteLine("Средний балл: " + avg.ToString("F1"));
int max = scores[0];
int maxNum = 1;
for (int i = 1; i < n; i++)
{
        if (scores[i] > max)
    {
        max = scores[i];
        maxNum = i + 1;
    }
}
Console.WriteLine("Лучший результат: " + max + " (студент №" + maxNum + ")");
int above = 0;
for (int i = 0; i < n; i++)
{
    if (scores[i] > avg)
    {
        above++;
    }
}
Console.WriteLine("Выше среднего: " + above + " из " + n);