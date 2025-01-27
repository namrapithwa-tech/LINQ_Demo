﻿// See https://aka.ms/new-console-template for more information
// Demo 1
Console.WriteLine("LINQ DEMO 1");
var students = Student.GetStudents();
foreach(var student in students)
{
    Console.WriteLine($"Roll No: {student.Rno}, Name: {student.Name}, Branch: {student.Branch}, " +
        $"Sem: {student.sem}, CPI: {student.CPI}");
}
// Demo 2
Console.WriteLine("LINQ DEMO 2");
var studentList = Student.GetStudents().Select(x => new Student()
{
    Rno = x.Rno,
    Name = x.Name,
    Branch = x.Branch,
    sem = x.sem,
    CPI = x.CPI
});
foreach(var student in studentList)
{
    Console.WriteLine($"Roll No: {student.Rno}, Name: {student.Name}, Branch: {student.Branch}, " +
        $"Sem: {student.sem}, CPI: {student.CPI}");
}

// Demo 3
Console.WriteLine("LINQ DEMO 3");
var studentList1 = Student.GetStudents()
    .Select(x => new
    {
        NameAndRno = x.Name + "-" + x.Rno,
        Branch = x.Branch,
        sem = x.sem,
        CPI = x.CPI
    });
foreach(var student in studentList1)
    {
    Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, " +
        $"Sem: {student.sem}, CPI: {student.CPI}");
}

// Demo 4 where clause
Console.WriteLine("LINQ DEMO 4 Where Clause");
var studentList2 = Student.GetStudents()
    .Where(x => x.CPI > 7)
    .Select(x => new
    {
        NameAndRno = x.Name + "-" + x.Rno,
        Branch = x.Branch,
        sem = x.sem,
        CPI = x.CPI
    });
foreach(var student in studentList2)
    {
    Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, " +
        $"Sem: {student.sem}, CPI: {student.CPI}");
    }

// Demo 5 Where clause with multiple conditions
Console.WriteLine("LINQ DEMO 5 Where Clause with multiple conditions");
Console.WriteLine(
    "Enter the minimum CPI: ");
Console.WriteLine(
    "Enter the minimum sem: ");
var minCPI = Convert.ToDouble(Console.ReadLine());
var minSem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(
    "Enter the maximum CPI: ");
Console.WriteLine(
    "Enter the maximum sem: ");
var maxCPI = Convert.ToDouble(Console.ReadLine());
var maxSem = Convert.ToInt32(Console.ReadLine());
var studentList3 = Student.GetStudents()
    .Where(x => x.CPI >= minCPI && x.CPI <= maxCPI && x.sem >= minSem && x.sem <= maxSem)
    .Select(x => new
    {
        NameAndRno = x.Name + "-" + x.Rno,
        Branch = x.Branch,
        sem = x.sem,
        CPI = x.CPI
    });
foreach(var student in studentList3)
    {
    Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, " +
        $"Sem: {student.sem}, CPI: {student.CPI}");
    }


public class Student()
{
    public int Rno { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }
    public int sem { get; set; }
    public double CPI { get; set; }

    public static List<Student>GetStudents()
    {
        List<Student> students = new List<Student>()
        {
            new Student{Rno=101, Name="Namra", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=102, Name="Jensi", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=103, Name="Sumit", Branch="CSE", sem=5, CPI=5.5 },
            new Student{Rno=104, Name="Meet", Branch="CSE", sem=5, CPI=6.5 },
            new Student{Rno=105, Name="Krisha", Branch="CSE", sem=6, CPI=2.5 },
            new Student{Rno=106, Name="Reni", Branch="CSE", sem=4, CPI=7.5 },
            new Student{Rno=107, Name="Rohan", Branch="CSE", sem=6, CPI=3.5 },
            new Student{Rno=108, Name="Raj", Branch="CSE", sem=6, CPI=7.9 },
            new Student{Rno=109, Name="Riya", Branch="CSE", sem=3, CPI=7.8 },
            new Student{Rno=110, Name="Rohan", Branch="CSE", sem=6, CPI=7.5 },
        };
        return students;
    }
}

