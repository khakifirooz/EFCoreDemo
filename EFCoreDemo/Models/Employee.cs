using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models;


[Table("EmployeeTable", Schema = "HR")]  // if we want to chnge the name of the sql table (not default name)
public class Employee
{


    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }

    public Employee(string name, string family)
    {
        Name = name;
        Family = family;
    }


























    //public int Id { get; set; }
    //[Column("FirstName", TypeName = "varchar(50)")]
    //[ConcurrencyCheck]
    //public string Name { get; set; }       // nullable
    //[ConcurrencyCheck]
    //public string? Family { get; set; }   // aloww null data
    //public string Mobile { get; set; }

    //public DateOnly BirthDay { get; set; }

    //[NotMapped]
    //public int? Age { get; set; }
    //// public Department Department { get; set; }  // Navigation_property

    ////[Timestamp]
    ////public byte[] RowVersion { get; set; }

}
