string[] rowsCols = Console.ReadLine().Split();

int rows = int.Parse(rowsCols[0]);
int cols = int.Parse(rowsCols[1]);

string[,] matrix = new string[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine().Split();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] commandTokkens = command.Split();

    if (commandTokkens.Length != 5)
    {
        Console.WriteLine("Invalid input!");
    }
    else
    {
        string action = commandTokkens[0];
        int row1 = int.Parse(commandTokkens[1]);
        int col1 = int.Parse(commandTokkens[2]);
        int row2 = int.Parse(commandTokkens[3]);
        int col2 = int.Parse(commandTokkens[4]);

        string originalValue = string.Empty;
        string swapValue = string.Empty;

        if (action == "swap" && row1 >= 0 && row1 < matrix.GetLength(0)
            && col1 >= 0 && col1 < matrix.GetLength(1)
            && row2 >= 0 && row2 < matrix.GetLength(0)
            && col2 >= 0 && col2 < matrix.GetLength(1))
        {
            originalValue = matrix[row1, col1];
            swapValue = matrix[row2, col2];

            matrix[row1, col1] = swapValue;
            matrix[row2, col2] = originalValue;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }

        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }

    command = Console.ReadLine().ToLower();
}

