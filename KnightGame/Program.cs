int nRows = int.Parse(Console.ReadLine());

string[,] figures = new string[nRows, nRows];

for (int r = 0; r < figures.GetLength(0); r++)
{
    string rowInput = Console.ReadLine();

    //char[] rowInput = input.ToCharArray();

    for (int c = 0; c < figures.GetLength(1); c++)
    {
        figures[r, c] = rowInput[c].ToString();
    }
}

if (nRows < 3)
{
    Console.WriteLine("0");
    return;
}

int removedKnights = 0;

while (true)
{
    int maxHits = 0;
    int rowToMostAtacckingKnight = 0;
    int colToMostAtacckingKnight = 0;

    for (int row = 0; row < nRows; row++)
    {
        for (int col = 0; col < nRows; col++)
        {
            string currentKnight = figures[row, col];

            int currentKnightHits = 0;

            if (currentKnight == "K")
            {
                if (row - 2 >= 0
                    && row - 2 < nRows
                    && col - 1 >= 0
                    && col - 1 < nRows)
                {
                    if (currentKnight == figures[row - 2, col - 1])
                    {
                        currentKnightHits++;
                    }
                }
                if (row - 2 >= 0
                    && row - 2 < nRows
                    && col + 1 >= 0
                    && col + 1 < nRows)
                {
                    if (currentKnight == figures[row - 2, col + 1])
                    {
                        currentKnightHits++;
                    }
                }
                if (row + 2 >= 0
                    && row + 2 < nRows
                    && col - 1 >= 0
                    && col - 1 < nRows)
                {
                    if (currentKnight == figures[row + 2, col - 1])
                    {
                        currentKnightHits++;
                    }
                }
                if (row + 2 >= 0
                    && row + 2 < nRows
                    && col + 1 >= 0
                    && col + 1 < nRows)
                {
                    if (currentKnight == figures[row + 2, col + 1])
                    {
                        currentKnightHits++;
                    }
                }

                if (row - 1 >= 0
                    && row - 1 < nRows
                    && col - 2 >= 0
                    && col - 2 < nRows)
                {
                    if (currentKnight == figures[row - 1, col - 2])
                    {
                        currentKnightHits++;
                    }
                }

                if (row - 1 >= 0
                    && row - 1 < nRows
                    && col + 2 >= 0
                    && col + 2 < nRows)
                {
                    if (currentKnight == figures[row - 1, col + 2])
                    {
                        currentKnightHits++;
                    }
                }

                if (row + 1 >= 0
                    && row + 1 < nRows
                    && col - 2 >= 0
                    && col - 2 < nRows)
                {
                    if (currentKnight == figures[row + 1, col - 2])
                    {
                        currentKnightHits++;
                    }
                }

                if (row + 1 >= 0
                    && row + 1 < nRows
                    && col + 2 >= 0
                    && col + 2 < nRows)
                {
                    if (currentKnight == figures[row + 1, col + 2])
                    {
                        currentKnightHits++;
                    }
                }

                if (currentKnightHits > maxHits)
                {
                    maxHits = currentKnightHits;
                    rowToMostAtacckingKnight = row;
                    colToMostAtacckingKnight = col;
                }
            }
        }
    }
    if (maxHits == 0)
    {
        break;
    }
    else
    {
        figures[rowToMostAtacckingKnight, colToMostAtacckingKnight] = "0";
        removedKnights++;
    }
}
Console.WriteLine(removedKnights);
