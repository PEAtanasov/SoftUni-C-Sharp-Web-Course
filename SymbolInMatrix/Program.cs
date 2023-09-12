int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int r = 0; r < matrix.GetLength(0); r++)
{
    string rowInput = Console.ReadLine();
    char[] chars = rowInput.ToCharArray();

    for (int c = 0; c < matrix.GetLength(1); c++)
    {
        matrix[r, c] = chars[c];
    }

}

char symbolToFind = char.Parse(Console.ReadLine());

int row = 0;
int col = 0;
//int counter = 0;
bool isFound = false;
for (int rw = 0; rw < matrix.GetLength(0); rw++)
{
    for (int cm = 0; cm < matrix.GetLength(1); cm++)
    {
        if (matrix[rw, cm] == symbolToFind)
        {
            row = rw;
            col = cm;
            //counter++;

            isFound = true;
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}
if (isFound)
{
    Console.WriteLine($"({row}, {col})");
}
else
{
    Console.WriteLine($"{symbolToFind} does not occur in the matrix");
}
