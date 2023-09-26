string[] rowsCols = Console.ReadLine().Split();

int rows = int.Parse(rowsCols[0]);
int cols = int.Parse(rowsCols[1]);

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    char[] rowTokens = Console.ReadLine().Split().Select(char.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowTokens[col];
    }
}

int counter = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int firstSymbol = matrix[row, col];
        int secondSymbol = matrix[row, col + 1];
        int thirdSymbol = matrix[row + 1, col];
        int fourthSymbol = matrix[row + 1, col + 1];

        if (firstSymbol == secondSymbol && firstSymbol == thirdSymbol && firstSymbol == fourthSymbol)
        {
            counter++;
        }
    }

}
Console.WriteLine(counter);

