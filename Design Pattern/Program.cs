using Design_Pattern;

// Builder Design Pattern

var employee = new EmployeeBuilder()
    .SetName("Vishal")
    .SetCity("Pune")
    .SetSalary(1000)
    .SetDepartment("Emgineering")
    .SetAge(28)
    .Build();

Console.WriteLine($"Name : {employee.Name}");
Console.WriteLine($"City : {employee.City}");
Console.WriteLine($"Salary : {employee.Salary}");
Console.WriteLine($"Age : {employee.Age}");
Console.WriteLine($"Department : {employee.Department}");

