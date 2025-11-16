using EFCoreDemo.Models;

using var context = new EFCoreDemoContext();
//var employee = context.Employees.Find(1);

//employee.Name = "Nima";
//context.SaveChanges();

var employee2 = new Employee() { Id = 1, Name = "Mehrshad", Family = "Khaki" };
context.Employees.Update(employee2);
context.SaveChanges();

Console.ReadKey();


