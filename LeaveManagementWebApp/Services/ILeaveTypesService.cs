using System;
using LeaveManagementWebApp.Models.LeaveTypes;

namespace LeaveManagementWebApp.Services;

public interface ILeaveTypesService
{
        Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<IndexVM>> GetAll();
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
