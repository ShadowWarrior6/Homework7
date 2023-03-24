Console.WriteLine("введите кол строк ");
int lines = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("введите кол столбцов ");
int column = Convert.ToInt32(Console.ReadLine()!);
double[,] numbers = new double[lines, column];
FillArrayRandomNumbers(numbers);
PintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; i < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;

        }
    }
}
void PintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; i < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");

    }
}