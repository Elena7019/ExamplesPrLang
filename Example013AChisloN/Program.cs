//Второй способ решения задачи про ряд чисел от -N до N
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a=-N;
int b=N; // [-N] = [a,b}]
for(int i=a; i<=b; i++)
{
    Console.Write(i+" ");
}
Console.WriteLine();