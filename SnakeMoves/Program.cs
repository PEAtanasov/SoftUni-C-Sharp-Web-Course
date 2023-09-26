string[] rowsCols = Console.ReadLine().Split();

int rows = int.Parse(rowsCols[0]);
int cols = int.Parse(rowsCols[1]);

string[,] matrix = new string[rows, cols];

string snake = Console.ReadLine();

int startIndex = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{

    if (row % 2 == 0) // right direction
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = snake[startIndex].ToString();
            startIndex++;
            if (startIndex >= snake.Length)
            {
                startIndex = 0;
            }
        }
    }
    else if (row % 2 != 0) // left direction
    {
        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
        {
            matrix[row, col] = snake[startIndex].ToString();
            startIndex++;
            if (startIndex >= snake.Length)
            {
                startIndex = 0;
            }
        }
    }
}

for (int r = 0; r < matrix.GetLength(0); r++)
{
    for (int c = 0; c < matrix.GetLength(1); c++)
    {
        Console.Write(matrix[r, c]);
    }
    Console.WriteLine();
}