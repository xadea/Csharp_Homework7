// прога ищет заданное число в массиве

Console.Clear();

Console.Write("How many rows? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns? ");
int n = Convert.ToInt32(Console.ReadLine());

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
    int x = 0, y = 4;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(array[i, j]);
            x = x + 6;
        }
        x = 0;
        y = y + 1;
    }
    Console.WriteLine();
}

Console.Write("Enter a number ");
int number = Convert.ToInt32(Console.ReadLine());

Display(myarray);

bool search = false;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       if (number == myarray[i,j])
       {
        Console. WriteLine($"Numbers {number} position is {i}, {j}");
        search = true;
        break;
       }
    }
    if (search == true) break;
}

if (search == false) Console.WriteLine(($"Number {number} doesn't exist"));
