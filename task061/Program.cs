// Задача 61: Показать треугольник Паскаля. 
//*Сделать вывод в виде равнобедренного треугольника.

Console.Clear();
Console.Write("Введите высоту треугольника:");
int heightTriangle = int.Parse(Console.ReadLine());
Console.WriteLine();
PictureTriangle(heightTriangle);

void PictureTriangle(int height)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j <= (height - i); j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k <= i; k++)
        {
            Console.Write(" ");
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j <= (height - i); j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k <= i; k++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(k) * Factorial(i - k)));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

int Factorial(int num)
{
    int facNum = 1;
    for (int i = 1; i <= num; i++)
    { facNum *= i; }
    return (facNum);
}
