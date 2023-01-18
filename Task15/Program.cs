// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
    Console.WriteLine("нет");
else if (n == 2)
    Console.WriteLine("нет");
else if (n == 3)
    Console.WriteLine("нет");
else if (n == 4)
    Console.WriteLine("нет");
else if (n == 5)
    Console.WriteLine("нет");
else if (n == 6)
    Console.WriteLine("да");
else if (n == 7)
    Console.WriteLine("да");
else
    Console.WriteLine("Вы ошиблись, повторите ввод: ");