using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models;

[NotMapped]   // do not create table for this entity
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
