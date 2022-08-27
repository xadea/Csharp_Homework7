// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int m = new Random().Next(3,10); 
int n = new Random().Next(3,10);

int[,] myarray = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        myarray[i, j] = new Random().Next(1, 20);
    }
}
 
void Display(int[,] array)
{
    int x = 0, y = 3;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(array[i, j]);
            x = x + 4;
        }
        x = 0;
        y = y + 1;
    }
    Console.WriteLine();
}

Console.Write("Enter a rows number ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a columns number ");
int column = Convert.ToInt32(Console.ReadLine());

Display(myarray);

if(row>m-1 || column>n-1) 
{
    Console.WriteLine($"There is no position [{row}, {column}]");
}
else 
{
    Console.WriteLine($"[{row}, {column}] = {myarray[row, column]}");
}


