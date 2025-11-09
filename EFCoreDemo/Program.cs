

//using EFCoreDemo;

//using (var context = new EFCoreDemoContext())
//{
//    var result = context.Database.EnsureCreated();
//}

// Migration

using EFCoreDemo;
using EFCoreDemo.Models;

using (var context = new EFCoreDemoContext())
{
    // فقط برای تست اتصال دیتابیس
    Console.WriteLine("Ensuring database is created...");
    context.Database.EnsureCreated();
    Console.WriteLine("Database created successfully!");
}