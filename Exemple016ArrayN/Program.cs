// В массиве N найти элемент find
int[] array = {12, 23, 34, 56, 678, 54, 43, 43, 341, 90};

int n = array.Length;
int find = 43;
int index = 0;

while(index < n )
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}