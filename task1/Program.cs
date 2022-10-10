/*-Задача 1. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Введите количество строк:");
int n = Prompt("Введите количество столбцов:");
double[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    Random rnd = new Random();
    double[,] array = new double[rowLength, colLength];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =Convert.ToDouble(rnd.Next(minRange, maxRange))/10;
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            System.Console.Write($"{array [i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
double[,] array = GenerateArray(m, n, -100, 100);
PrintArray(array);
