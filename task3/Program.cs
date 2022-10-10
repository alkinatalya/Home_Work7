/*  Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception(" Данное значение не возможно преобразовать в число");
}

int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRange, maxRange + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();

}
void sredAr(int[,] arr, int a, int b)
{
    double result = 0;
    double count = 0;
    double average = 0;
    for (int j = 0; j < b; j++)
    {
        for (int i = 0; i < a; i++)
        {
            result = result + arr[i, j];
            count++;
        }
        average = result / count;
        System.Console.Write($"{average} \t");
         result = 0;
         count = 0;
    }
    System.Console.WriteLine();
}
int strings = Prompt("Введите количество строк:");
int columns = Prompt("Введите количество столбцов:");
int[,] array = GenerateArray(strings, columns, 0, 10);
PrintArray(array);
sredAr(array, strings, columns);

