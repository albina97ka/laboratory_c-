using System;

struct Student
{
    public string Name;
    public string GroupNumber;
    public int[] Grades;

    public double Calculate()
    {
        int sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return (double)sum / Grades.Length;
    }
}

class Class
{
    static void Main()
    {
        Student[] students = new Student[7];

        students[0] = new Student { Name = "Иванов И.И.", GroupNumber = "19ит15", Grades = new int[] { 4, 5, 3, 3, 5 } };
        students[1] = new Student { Name = "Петров П.П.", GroupNumber = "19ит17", Grades = new int[] { 5, 3, 4, 5, 5 } };
        students[2] = new Student { Name = "Сидоров С.С.", GroupNumber = "20ит15", Grades = new int[] { 3, 4, 4, 3, 3 } };
        students[3] = new Student { Name = "Козлов К.К.", GroupNumber = "19ит15", Grades = new int[] { 5, 5, 4, 5, 5 } };
        students[4] = new Student { Name = "Николаев Н.Н.", GroupNumber = "19ит15", Grades = new int[] { 3, 3, 3, 4, 2 } };
        students[5] = new Student { Name = "Смирнов С.С.", GroupNumber = "20ит15", Grades = new int[] { 4, 4, 3, 4, 5 } };
        students[6] = new Student { Name = "Зайцев З.З.", GroupNumber = "19ит17", Grades = new int[] { 5, 5, 5, 5, 5 } };

        Array.Sort(students, (x, y) => x.Calculate().CompareTo(y.Calculate()));

        Console.WriteLine("Студенты, упорядоченные по возрастанию среднего балла:");
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.Name}, Группа: {student.GroupNumber}, Средний балл: {student.Calculate():F2}");
        }
    }
}