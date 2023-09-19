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

int biggestSum = 0;
int first = 0;
int second = 0;
int third = 0;
int fourth = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int firstNumber = matrix[row, col];
        int secondNumber = matrix[row, col + 1];
        int thirdNumber = matrix[row + 1, col];
        int fourthNumber = matrix[row + 1, col + 1];

        int currentSum = firstNumber + secondNumber + thirdNumber + fourthNumber;

        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;
            first = firstNumber;
            second = secondNumber;
            third = thirdNumber;
            fourth = fourthNumber;
        }
    }
}
Console.WriteLine($"{first} {second}");
Console.WriteLine($"{third} {fourth}");
Console.WriteLine(biggestSum);

