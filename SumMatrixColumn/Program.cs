string[] rowsColsInfo = Console.ReadLine()
    .Split(", ");

int rows = int.Parse(rowsColsInfo[0]);
int cols = int.Parse(rowsColsInfo[1]);

int[,] ints = new int[rows, cols];

for (int row = 0; row < ints.GetLength(0); row++)
{
    int[] rowInput = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < ints.GetLength(1); col++)
    {
        ints[row, col] = rowInput[col];
    }
}

for (int c = 0; c < ints.GetLength(1); c++)
{
    int currentColSum = 0;
    for (int r = 0; r < ints.GetLength(0); r++)
    {
        currentColSum += ints[r, c];
    }
    Console.WriteLine(currentColSum);
}
