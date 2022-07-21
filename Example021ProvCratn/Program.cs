//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = number % 7 == 0 && number % 23 == 0;
if(!result)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}*/
void Zadacha14()
{
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    bool test = (a%7==0) & (a%23==0);
    if(test==true)
    {
        Console.WriteLine($"Число {a} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {a} не кратно 7 и 23");
    }
}

Zadacha14();