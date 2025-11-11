using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models;


[Table("EmployeeTable", Schema = "HR")]  // if we want to chnge the name of the sql table (not default name)
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }       // nullable
    public string? Family { get; set; }   // aloww null data
    public string Mobile { get; set; } 
    public int? Age { get; set; }
    public Department Department { get; set; }  // Navigation_property
}
