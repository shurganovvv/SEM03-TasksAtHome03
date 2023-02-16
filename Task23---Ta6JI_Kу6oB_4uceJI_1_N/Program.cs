// Задача 23: Напишите программу, которая 
//     принимает на вход число (N) 
//     и выдаёт таблицу кубов чисел от 1 до N.
//         3 -> 1, 8, 27 
//         5 -> 1, 8, 27, 64, 125

void cubesNumber(int counter, int number)
{
    if (counter < number)
    {
        System.Console.Write(", ");
        counter++;
        System.Console.Write(Math.Pow(counter, 3));
        cubesNumber(counter, number);
    }
    else System.Console.WriteLine(".");
}

Console.WriteLine("Давай число!");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
System.Console.Write(i);
cubesNumber(i, N);

for (i = 1; i < N; i++)
{
    System.Console.Write(i * i * i + ", ");
}
System.Console.WriteLine(N * N * N + ".");