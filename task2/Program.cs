/*Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание,
 что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/
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

void indexArray(int i, int j, int[,]arr, int a, int b)
{
    if (i < a && j < b)
    {
        System.Console.WriteLine(arr [i, j]);
    }
    else
    {
        System.Console.WriteLine("Нет в массиве такой позиции");
    }
}
int strings = Prompt("Введите количество строк:");
int columns = Prompt("Введите количество столбцов:");
int[,] array = GenerateArray(strings, columns, 0, 10);
PrintArray(array);
int indexString = Prompt("ВВедите index строки>");
int indexColumn = Prompt("Введите index столбца>");
indexArray(indexString, indexColumn, array, strings, columns);