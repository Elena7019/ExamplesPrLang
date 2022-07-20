// Напишите программу, которая выводит случайное трехзначное число и далаяет среднюю цифру из него
/*void Zadacha11()
{
Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);
int digitSot = number/100;
int digitOnes = (number - 100*digitSot)%10;

Console.WriteLine(digitSot + ""+ digitOnes);
}

Zadacha11();*/

/*void Sposob2()
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine(number);
    int digitSot = number/100;
    int digitOnes = number%10;
    Console.WriteLine(digitSot*10 + digitOnes);
}

Sposob2();*/

void Sposob3()
{
    string number = Convert.ToString(new Random().Next(100, 999));
    int count = 0;
    Console.WriteLine(number);
    foreach(char c in number)
    {
        count++;
        if(count !=2)
        {
            Console.Write(c);
        }
    }
    Console.WriteLine();
}

Sposob3();