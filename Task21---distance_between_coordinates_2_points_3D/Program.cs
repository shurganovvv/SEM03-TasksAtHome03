// Задача №21. Напишите программу, которая 
//     принимает на вход координаты двух точек 
//     и находит расстояние между ними в 3D пространстве.
//         A (3,6,8); B (2,1,-7), -> 15.84
//         A (7,-5, 0); B (1,-1,9) -> 11.53
//                                         √[ (x₂-x₁)² + (y₂-y₁)² + (z₂-z₁)² ]

Console.WriteLine("Ну, раз ты уже знаешь все координаты всех точек, тогда давай сразу сократим расход памяти.");

Console.Write("Первая координата Первой точки: X1 = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Первая координата Второй точки: X2 = ");
x = Math.Pow(Convert.ToDouble(Console.ReadLine()) - x, 2);
System.Console.WriteLine(x);

Console.Write("Вторая координата Первой точки: Y1 = ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Вторая координата Второй точки: Y2 = ");
y = Math.Pow(Convert.ToDouble(Console.ReadLine()) - y, 2);
System.Console.WriteLine(y);

Console.Write("Третья координата Первой точки:  Z1 = ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Третья координата Второй точки Z2= ");
z = Math.Pow(Convert.ToDouble(Console.ReadLine()) - z, 2);
System.Console.WriteLine(z);

x = Math.Sqrt(x + y + z);
// System.Console.WriteLine("Ого! Вот это число... Давай сократим. Сколько цифр после запятой оставить?");
// y = Convert.ToInt32(Console.ReadLine());
z = Math.Round(x, 3);   // хотел задействовать 'y', но возникла ошибка:  
// <<не удается преобразовать из "double" в "int">>,
// подскажете, как можно это сделать, не прибегая к помощи новой переменной?
Console.WriteLine("Расстояние между двумя указанными точками составляет " + z + " у.ё.");