public class Person
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - Birthday.Year;
        if (today < Birthday.AddYears(age))
            age--;
        return age;
    }
}

public class Employee : Person
{
    public int Id { get; set; }
    public string DivisionName { get; set; }
}

public class Student : Person
{
    public int Grade { get; set; }
    public int ClassNumber { get; set; }
}

class Test
{
    public void Main(string[] arg)
    {
        Employee employee = new Employee
        {
            Id = 100,
            Name = "hirayama",
            Birthday = new DateTime(1997, 1, 29),
            DivisionName = "チームA",
        };

        Console.writeLine("{0}({1})は、{2}に所属しています。", employee.Name, employee.GetAge(), employee.DivisionName);

        var student = new Student
        {
            Name = "tanaka",
            Birthday = new DateTime(1997, 1, 29),
            Grade = 3,
            ClassNumber = 1,
        };

        System.Console.WriteLine("{0}年{1}組の{2}です。誕生日は{3}です。", student.Grade, student.ClassNumber, student.Name, student.Birthday);

        Person hoge = student;
        object fuga = student;
    }
}