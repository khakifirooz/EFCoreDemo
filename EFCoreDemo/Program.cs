using EFCoreDemo.Models;

using var context = new EFCoreDemoContext();
//var employee = context.Employees.Find(1);

//employee.Name = "Nima";
//context.SaveChanges();

var employee2 = new Employee() { Id = 1, Name = "Mehrshad", Family = "Khaki" };
context.Employees.Update(employee2);


var employee3 = new Employee("Ahmad", "Heidari");
context.Add(employee3);

var removeEmployee1 = context.Employees.Find(1);
context.Employees.Remove(removeEmployee1);

context.SaveChanges();

Console.ReadKey();


