using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWebApp.Models.LeaveTypes;

public class LeaveTypeCreateVM
{
    [Required]
    [Length(4,150, ErrorMessage ="You have violated length requirements")]
    public String Name { get; set; } = String.Empty;
    [Required]
    [Range(1,90)]
    [Display(Name ="Number of Days")]
    public int NumberOfDays { get; set; }
}
