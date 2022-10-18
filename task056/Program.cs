// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] numersArray = UserEnterNumersConsol();
Console.Write("Массив :");
OutputArrayConsol(numersArray);
Console.WriteLine($"Строка массива с наименьшей суммой элементов : {MinSumArray(numersArray)}");

int[,] UserEnterNumersConsol()
{
    Console.Write("Введите размерность массива: ");
    int sise = int.Parse(Console.ReadLine());
    int[,] enterNumersArray = new int[sise, sise];
    for (int i = 0; i < sise; i++)
    {
        for (int j = 0; j < sise; j++)
        {
            enterNumersArray[i, j] = new Random().Next(-99, 100);
        }
    }
    Console.WriteLine();
    return (enterNumersArray);
}

void OutputArrayConsol(int[,] numerArray)
{
    Console.WriteLine();
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            Console.Write($"{numerArray[i, j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int MinSumArray(int[,] numerArray)
{
    int[] sumNumsStringArray = new int[numerArray.GetLength(0)];
    for (int i = 0, k = 1; i <= numerArray.GetUpperBound(0); i++, k++)
    {
        int sum=0;
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            sum = sum + numerArray[i, j];
        }
        sumNumsStringArray[i] = sum;
    }
    int minSum = sumNumsStringArray[0],
        indexString=0;
    for (int i = 0; i < sumNumsStringArray.Length; i++)
    {
        if ((minSum != sumNumsStringArray[i]) && (minSum > sumNumsStringArray[i]))
        {
            minSum = sumNumsStringArray[i];
            indexString = i;
        }
    }
    return (indexString+1);
}