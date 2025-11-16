using EFCoreDemo.Models;


using var context = new EFCoreDemoContext();
var employee = new Employee("Ali","Kamali");

context.Employees.Add(employee);
//context.Add<Employee>(employee); can be like this
context.SaveChanges();  // necessary 



Console.ReadKey();


