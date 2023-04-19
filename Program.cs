int[,] array = { { 7, 4, 3, 7, 9 }, { 1, 5, 4, 3, 2, }, { 6, 8, 9, 4, 1 }, { 4, 1, 3, 2, 7 }, { 7, 4, 3, 2, 1 } };
int sumInArray = 0;
int multiplicationInArray = 1;
int firstMeasurementInArray = 0;
int secondMeasurementInArray = 1;
int secondLine = 1;
int firstColumn = 0;

for (int i = 0; i < array.GetLength(firstMeasurementInArray); i++)
{
	for (int j = 0; j < array.GetLength(secondMeasurementInArray); j++)
	{
		if (firstColumn == j)
		{
			multiplicationInArray *= array[i, j];
		}

		Console.Write(array[i,j] + " ");
	}

	Console.WriteLine();
}

for (int i = 0; i < array.GetLength(firstMeasurementInArray); i++)
{
    for (int j = 0; j < array.GetLength(secondMeasurementInArray); j++)
    {
        if (secondLine == i)
        {
            sumInArray += array[i, j];
        }

        Console.Write(array[i, j] + " ");
    }

    Console.WriteLine();
}

Console.WriteLine($"Сумма второй строки равна {sumInArray}, а произведение первого столбца равно {multiplicationInArray}.");