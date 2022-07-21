//Рапишите программу, которая на вход принимает два числа и определяет, является ли одно из чисел квадратом второго
/*void Zadacha16()
{
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if(b == a * a)
    {
        Console.WriteLine($"Число {b} является квадратом числа {a}");
    }
    else if(a == b * b)
    {
        Console.WriteLine($"Число {a} является квадратом числа {b}");
    }
    else
    {
        Console.WriteLine("Ни одно число не является квадратом второго");
    }
}

Zadacha16();*/

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool cubic = b == a * a || a == b * b;
if(cubic)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }