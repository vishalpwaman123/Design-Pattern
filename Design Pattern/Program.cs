using Design_Pattern;

// Builder Design Pattern

//var employee = new EmployeeBuilder()
//    .SetName("Vishal")
//    .SetCity("Pune")
//    .SetSalary(1000)
//    .SetDepartment("Emgineering")
//    .SetAge(28)
//    .Build();

//Console.WriteLine($"Name : {employee.Name}");
//Console.WriteLine($"City : {employee.City}");
//Console.WriteLine($"Salary : {employee.Salary}");
//Console.WriteLine($"Age : {employee.Age}");
//Console.WriteLine($"Department : {employee.Department}");

// Factory Design Pattern

//var factory = new NotificationFactory();
//var notification = factory.create("EMAIL");
//notification.Send();

// Abstract Factory Design Pattern

IUIFactory factory;
string operatingSystem = "MAC";

if (operatingSystem.Equals("WINDOW"))
    factory = new WindowFactory();
else
    factory = new MacFactory();

IButton button = factory.CreateButton();
ICheckbox checkbox = factory.CreateCheckbox();
button.Render();
checkbox.Render();

// Singleton Desing Pattern

//var singleton1 = Singleton.GetInstance();
//var singleton2 = Singleton.GetInstance();
//singleton1.ShowMessage();
//Console.WriteLine(singleton1 == singleton2);

