int n = int.Parse(Console.ReadLine());

int[,] square = new int[n, n];
int[,] reversedSquare = new int[n, n];

for (int r = 0; r < square.GetLength(0); r++)
{
    int[] rows = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    int[] reversedArray = rows.Reverse().ToArray();

    for (int c = 0; c < square.GetLength(1); c++)
    {
        square[r, c] = rows[c];
        reversedSquare[r, c] = reversedArray[c];
    }
}

int firstDiagonalSum = 0;
int secondDiagonalSum = 0;

for (int row = 0; row < square.GetLength(0); row++)
{
    for (int col = 0; col < square.GetLength(1); col++)
    {
        if (row == col)
        {
            firstDiagonalSum += square[row, col];
            secondDiagonalSum += reversedSquare[row, col];

        }
    }
}

Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));