// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("How many rows? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns? ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myarray = new int[m, n];

Console.Write("Do you whant to fill the array by yourself?  y/n ");
string choice = Console.ReadLine();
if (choice == "y") FillArrayByUser(myarray);
else FillArray(myarray);

void FillArrayByUser(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write("Enter a number ");
           array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Display(int[,] array)
{
    Console.Clear();
    int x = 0, y = 1;
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

Display(myarray);
Console.WriteLine("Averages of every column are: ");

for (int j = 0; j < n; j++)
{
    double sum = 0;
    
    for (int i = 0; i < m; i++)
    {
        sum = sum + myarray[i, j];
    }
    sum = Math.Round(sum/m, 1);
    Console.Write(sum + "   ");
}