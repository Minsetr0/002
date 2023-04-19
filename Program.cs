Random random = new Random();

int columnsInArray = 10;
int linesInArray = 10;
int[,] array = new int[linesInArray, columnsInArray];
int maxNumberInArray = int.MinValue;
int replacementNumber = 0;
int minPossibleNumberInArray = 1;
int maxPossibleNumberInArray = 10;

Console.WriteLine("Матрица до изменения:\n");

for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
	{
        array[i,j] = random.Next(minPossibleNumberInArray, maxPossibleNumberInArray);

		if (maxNumberInArray < array[i,j])
		{
			maxNumberInArray = array[i,j];
		}

		Console.Write(array[i,j] + " ");
	}

    Console.WriteLine();
}

Console.WriteLine("\nМаксимальное число в матрице равно " + maxNumberInArray);
Console.WriteLine("Матрица после изменения:\n");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (maxNumberInArray == array[i, j])
        {
            array[i,j] = replacementNumber;
        }

        Console.Write(array[i, j] + " ");
    }

    Console.WriteLine();
}