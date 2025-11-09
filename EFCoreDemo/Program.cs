

using EFCoreDemo;

using (var context = new EFCoreDemoContext())
{
    var result = context.Database.EnsureCreated();
}