int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

numbers = numbers.OrderByDescending(x => x).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    if (i == 3)
    {
        break;
    }
    Console.Write(numbers[i] + " ");
}
