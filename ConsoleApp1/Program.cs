string rowsAndColumns = Console.ReadLine();

int[] rowsColsTokens = rowsAndColumns.Split(", ").Select(int.Parse).ToArray();

int rows = rowsColsTokens[0];
int cols = rowsColsTokens[1];

int[,] matrix = new int[rows, cols];



for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));

int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        sum += matrix[row, col];
    }

}
Console.WriteLine(sum);
