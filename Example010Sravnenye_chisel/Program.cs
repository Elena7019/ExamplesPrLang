Console.Write("a = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == numberA * numberA)
{
   Console.WriteLine("Первое число является квадратом второго"); 
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}