﻿//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в 
//каждом столбце

Console.WriteLine("введите массив");
int num_1=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("введите чесло");
int num_2=Convert.ToInt32(Console.ReadLine()!);

int[,] numbers = new int [num_1, num_2];
FilleArrayRandomNumbers(numbers);

for (int j=0;j<numbers.GetLength(1);j++)
{
    double avarage =0;
    for(int i=0;i<numbers.GetLength(0);i++)
    {
        avarage=(avarage+numbers[i,j]);

    } 
    avarage=avarage/num_1;
    Console.WriteLine(avarage+"; ");


}
Console.WriteLine();
PrintArray(numbers);

void FilleArrayRandomNumbers(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j =0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        Console.Write("[");
        for (int j =0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+" ");

        }
        Console.Write("]");
        Console.WriteLine(" ");
    
    }

}
