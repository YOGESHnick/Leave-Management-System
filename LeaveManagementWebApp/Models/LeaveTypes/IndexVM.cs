using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWebApp.Models.LeaveTypes;

public class IndexVM : BaseLeaveTypeVM
{
    
    public String Name { get; set; } = String.Empty;
    [Display(Name ="Number of Days")]
    public int NumberOfDays { get; set; }
}
