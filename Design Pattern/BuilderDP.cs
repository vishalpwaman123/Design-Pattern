using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    /*
     * Builder Design Pattern (Creational):
     * Separates the construction of a complex object from its representation,
     * allowing the same object to be built step by step (often via a fluent API)
     * with only the parts you need, instead of using large constructors with many parameters.
     */

    // Builder: builds an Employee step by step using chained (fluent) method calls.
    public class EmployeeBuilder
    {
        // The object being built; each Set method fills one part of it.
        private Employee _employee = new();

        // Sets the employee's name and returns the builder for chaining.
        public EmployeeBuilder SetName(string name)
        {
            _employee.Name = name;
            return this;
        }

        // Sets the employee's age and returns the builder for chaining.
        public EmployeeBuilder SetAge(int age)
        {
            _employee.Age = age;
            return this;
        }

        // Sets the employee's department and returns the builder for chaining.
        public EmployeeBuilder SetDepartment(string department)
        {
            _employee.Department = department;
            return this;
        }

        // Sets the employee's city and returns the builder for chaining.
        public EmployeeBuilder SetCity(string city)
        {
            _employee.City = city;
            return this;
        }

        // Sets the employee's salary and returns the builder for chaining.
        public EmployeeBuilder SetSalary(decimal salary)
        {
            _employee.Salary = salary;
            return this;
        }

        // Returns the fully constructed Employee object.
        public Employee Build() => _employee;
    }

    // Product: the complex object that the builder creates.
    public class Employee
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Department { get; set; }
        public string? City { get; set; }
        public decimal? Salary { get; set; }
    }
}


// Interview Answer

// Builder Design Pattern is a creational design pattern used to construct complex objects step-by-step. 
// It separates the object construction process from the final object. 
// It is useful when an object has many optional properties or complex construction logic. 
// It also commonly uses method chaining to make object creation readable.