//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

double InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return double.Parse(Console.ReadLine());
}

double SumNumbers(double m, double n)
{
    if (m > n) 
    {
        return 0;
    }
    return SumNumbers(m, n - 1) + n;
}

double mValue = InputInt("Введите значение М (натуральное число)"); 
double nValue = InputInt("Введите значение N (натуральное число)");
if (mValue > 0 && nValue > 0 && mValue % 1 == 0 && mValue % 1 == 0)
{
    double res = SumNumbers(mValue, nValue);
    System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {mValue} до {nValue} равна {res}!");
}
else 
{
    System.Console.WriteLine("Данные Вами значения не являются натуральными!");
}