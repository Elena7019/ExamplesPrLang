//Ввод двух чисел, проверка, является ли второе число кратным первому, если нет - вывод остатка от деления
void Zadacha12()
{
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int res = number2 % number1;
if (res > 0)
{
    Console.WriteLine("Второе число не кратно первому. Остаток от деления составляет ");
    Console.WriteLine(res);  
}
else
{
    Console.WriteLine("Второе число кратно первому");
}
}
Zadacha12();
/*Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int res = number2 % number1;
Console.WriteLine((number2%number1) == 0? $"Число {number2} кратно {number1}" : $"Остаток от деления: {number2%number1}");*/
