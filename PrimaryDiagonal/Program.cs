int matrixParameter = int.Parse(Console.ReadLine());


int[,] ints = new int[matrixParameter, matrixParameter];

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
int sum = 0;
for (int r = 0; r < ints.GetLength(0); r++)
{
    for (int c = 0; c < ints.GetLength(1); c++)
    {

        if (r == c)
        {
            sum += ints[r, c];
        }
    }
}
Console.WriteLine(sum);
