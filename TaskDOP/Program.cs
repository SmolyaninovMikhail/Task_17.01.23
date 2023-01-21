// Task dop

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int maxFirst = n;
int maxSecond = 0;
while (n != 0)
{
n = Convert.ToInt32(Console.ReadLine());
if (n > maxFirst)
{
    maxSecond = maxFirst;
    maxFirst = n;
}
else if (n > maxSecond)
    maxSecond = n;
}
Console.WriteLine(maxSecond);


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = 0;
// while (n != 0)
// {
// n = Convert.ToInt32(Console.ReadLine());
// if (n > max1)
// {
// max2 = max1;
// max1 = n;
// }
// else if (n > max2)
// max2 = n;
// }
// Console.WriteLine(max2);