using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWebApp.Models.LeaveTypes;

public class LeaveTypeEditVM
{
    public int Id { get; set; }
    [Required]
    [Length(4,150, ErrorMessage ="You have violated length requirements")]
    public String Name { get; set; } = String.Empty;
    [Required]
    [Range(1,90)]
    public int NumberOfDays { get; set; }
}