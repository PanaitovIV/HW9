// Задайте значения M и n. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до n с помощью рекурсии.

Console.Clear();

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void Recursion(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 != 0)
    {
        m++;
        System.Console.Write($"{m} ");
        Recursion(m + 2, n);
    }
    else
    {
        System.Console.Write($"{m} ");
        Recursion(m + 2, n);
    }
}

int mValue = InputInt("Введите значение М");
int nValue = InputInt("Введите значение N");
Recursion(mValue, nValue);