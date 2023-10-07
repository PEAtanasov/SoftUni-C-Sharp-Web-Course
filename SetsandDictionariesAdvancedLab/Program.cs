int numberOfStudents = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < numberOfStudents; i++)
{
    string[] studentInfo = Console.ReadLine().Split();

    string name = studentInfo[0];
    decimal grade = decimal.Parse(studentInfo[1]);

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<decimal>());
    }

    students[name].Add(grade);
}

foreach (var student in students)
{
    Console.Write($"{student.Key} -> "); foreach (var grade in student.Value)
    {
        Console.Write($"{grade:f2} ");
    }
    Console.Write($"(avg: {student.Value.Average():f2})");
    Console.WriteLine();
}
