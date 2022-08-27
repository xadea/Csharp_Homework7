// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами

Console.Clear();

Console.Write("How many rows? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns? ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myarray = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        myarray[i, j] = new Random().NextDouble() * 40 - 20;
    }
}

void Display(double[,] array)
{
    int x = 0, y = 3;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Math.Round(array[i, j], 1));
            x = x + 8;
        }
        x = 0;
        y = y + 1;
    }
    Console.WriteLine();
}

Display(myarray);