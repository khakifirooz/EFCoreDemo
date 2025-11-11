namespace EFCoreDemo.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }       // nullable
    public string? Family { get; set; }   // aloww null data
    public string Mobile { get; set; } 
    public int? Age { get; set; }
    public Department Department { get; set; }  // Navigation_property
}
