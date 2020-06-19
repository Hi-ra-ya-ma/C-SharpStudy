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
    }
}