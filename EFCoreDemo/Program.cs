

//using EFCoreDemo;

//using (var context = new EFCoreDemoContext())
//{
//    var result = context.Database.EnsureCreated();
//}

// Migration

using EFCoreDemo;
using EFCoreDemo.Migrations;
using EFCoreDemo.Models;


try
{
    Thread t1 = new Thread(Update1);
    Thread t2 = new Thread(Update1);
    t1.Start();
    t2.Start();
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + "please try again later !!");
}
static void Update1()
{
    
    EFCoreDemoContext _context = new EFCoreDemoContext();
    var employee = _context.Employees.Find(1);
    if (employee != null)
    {
        _context.Employees.Remove(employee);
        _context.SaveChanges();
    }
}

static void Update2()
{
    Thread.Sleep(1000);
    EFCoreDemoContext _context = new EFCoreDemoContext();
    var employee = _context.Employees.Find(1);
    if (employee != null)
    {
        employee.Name = "Hasan";
        _context.SaveChanges();
    }
}


