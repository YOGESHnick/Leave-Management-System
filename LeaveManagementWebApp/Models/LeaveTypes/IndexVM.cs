using System;

namespace LeaveManagementWebApp.Models.LeaveTypes;

public class IndexVM
{
    public int Id { get; set; }
    public String Name { get; set; } = String.Empty;
    public int NumberOfDays { get; set; }
}
