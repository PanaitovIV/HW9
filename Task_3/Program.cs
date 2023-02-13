// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int CalculatingFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return CalculatingFunction(m - 1, 1);
    }
    else return CalculatingFunction(m - 1, CalculatingFunction(m, n - 1));
}

int mValue = InputInt("Введите значение М (положительное число)");
int nValue = InputInt("Введите значение N (положительное число)");
if (mValue > 0 && nValue > 0)
{
    int res = CalculatingFunction(mValue, nValue);
    System.Console.Write($"A(m,n) = {res}");
}
else 
{
    System.Console.WriteLine("Данные Вами значения не являются положительными!");
}