//решение для положительных и отрицательных чисел (ряд чисел от -N до N)
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int startnumber = -number;
while(startnumber != (number + 1))
{
    Console.Write(startnumber + ",");
    startnumber+=1;
}
Console.Write("\b.");
Console.WriteLine();
