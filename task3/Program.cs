/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Enter the number");
bool isParse = int.TryParse(Console.ReadLine(), out int N);

if(N < 0)
{
    Console.WriteLine("invalid value");
    return;
}
int[] array = Calculate(N);
PrintArray(array);

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int [] Calculate(int N)
{
    int[] local_array = new int [N];

    for(int i = 1; i <= N; i++)
    {
        local_array[i-1] = i * i * i;
    }
    return local_array;
}