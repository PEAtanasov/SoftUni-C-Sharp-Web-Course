int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < jaggedArray.Length; row++)
{
    int[] cols = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    jaggedArray[row] = cols;
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] commandTokens = command.Split();

    string action = commandTokens[0];
    int row = int.Parse(commandTokens[1]);
    int col = int.Parse(commandTokens[2]);
    int value = int.Parse(commandTokens[3]);

    bool isvalied = true;

    if (row < 0 || jaggedArray.Length <= row)
    {
        isvalied = false;
    }
    else if (col < 0 || jaggedArray[row].Length <= col)
    {
        isvalied = false;
    }

    if (isvalied)
    {
        if (action == "add")
        {
            jaggedArray[row][col] += value;
        }
        else if (action == "subtract")
        {
            jaggedArray[row][col] -= value;
        }
    }
    else if (true)
    {
        Console.WriteLine("Invalid coordinates");
    }

    command = Console.ReadLine().ToLower();
}

foreach (var item in jaggedArray)
{
    Console.WriteLine(string.Join(" ", item));
}

