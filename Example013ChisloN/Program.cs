Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startnumber = -number;
while(startnumber != (number + 1))
{
    Console.Write(startnumber + ",");
    startnumber+=1;
}
Console.Write("\b,");
Console.WriteLine();