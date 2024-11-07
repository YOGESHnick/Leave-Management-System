using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWebApp.Data;

public class LeaveType
{
     public int Id { get; set; }
    // [MaxLength(150)]
    [Column(TypeName = "nvarchar(150)")]
    public required string  Name { get; set; }
    public int NumberOfDays { get; set; }
}
