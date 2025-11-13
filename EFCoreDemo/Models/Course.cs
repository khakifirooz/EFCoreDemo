namespace EFCoreDemo.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
}
