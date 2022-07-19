Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента:");
int i0 = Convert.ToInt32(Console.ReadLine());
int j0 = Convert.ToInt32(Console.ReadLine());



int[,] array = new int[M, N];

Random rnd = new Random();

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
    array[i, j] = rnd.Next(0, 10);
    Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

if (i0 >= M && j0 >= N || i0 < 0 || j0 < 0)
Console.WriteLine("Такого числа в массиве нет.");
else
Console.WriteLine("Элемент {0}", array[i0, j0]);