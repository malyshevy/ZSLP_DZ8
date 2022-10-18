// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
int[,,] numersArray = EnterArray();
ResultOutput(numersArray);

int[,,] EnterArray()
{
    int[,,] enterNumersArray =
   {
    {
        {88,95},
        {23,21}
    },
    {
        {60,75},
        {89,79}
    }
   };
    return (enterNumersArray);
}

void ResultOutput(int[,,] numerArray)
{
    Console.WriteLine("Массив размером 2 x 2 x 2");
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            for (int k = 0; k <= numerArray.GetUpperBound(2); k++)
            { Console.Write($"{numerArray[i, j, k]} ({i},{j},{k}) "); }
            Console.WriteLine();
        }
    }
}

