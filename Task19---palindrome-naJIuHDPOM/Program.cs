// Задача 19: Напишите программу, которая 
//     принимает на вход пятизначное число 
//     и проверяет, является ли оно палиндромом.
//         14212 -> нет
//         23432 -> да
//         12821 -> да

/* хотел начать сдерживать и не усложнять себе задачи - не вышло... */
int intMathematics(int n)
{
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (number > 9999 && number < 100000)
    {
        // int digit5 = number % 10;
        // int digit4 = number / 10 % 10;
        // int digit3 = number / 100 % 10;
        // int digit2 = number / 1000 % 10;
        // int digit1 = number / 10000;
        // System.Console.Write($"{digit1} {digit2} {digit3} {digit4} {digit5}: ");
        // if (digit1 == digit5 && digit2 == digit4)
        // то же самое, но без лишних переменных:
        if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
            System.Console.WriteLine("палиндромом - теперь можно в КАБАК");
        else System.Console.WriteLine("НЕ палиндромом - давай-ка, чапай за розой");
        n = 5;
    }
    else System.Console.WriteLine("Пожалуйста, ПЯТИзначное число!");
    return n;
}

int stringLine(int n)
{
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    string arrayNumbers = Convert.ToString(number);
    if (arrayNumbers.Length == 5)
    {
        if (arrayNumbers[0] == arrayNumbers[4] && arrayNumbers[1] == arrayNumbers[3])
            System.Console.WriteLine($"{arrayNumbers[0]} {arrayNumbers[1]} {arrayNumbers[2]} {arrayNumbers[3]} {arrayNumbers[4]}: палиндромом - теперь можно в КАБАК");
        else System.Console.WriteLine($"{arrayNumbers[0]} {arrayNumbers[1]} {arrayNumbers[2]} {arrayNumbers[3]} {arrayNumbers[4]}: НЕ палиндромом - давай-ка, чапай за розой");
        n = 5;
    }
    else System.Console.WriteLine("Пожалуйста, ПЯТИзначное число!");
    return n;
}

System.Console.WriteLine();
System.Console.WriteLine("если ты Физик, пропиши '0'.");
System.Console.WriteLine("если Лирик, то не заморачивайся особенно - жми любую цифру и маршь учить матчамть!");
int physLyr = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
Console.WriteLine("Введите пятизначное число");
int i;
for (i = 0; i < 3; i++)
{
    if (physLyr == 0) i = intMathematics(i);
    else i = stringLine(i);
}
if (i < 5)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Хорошо - я понял. Вопросов больше не имею...");
    System.Console.WriteLine();
}