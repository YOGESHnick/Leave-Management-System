using System;
using AutoMapper;
using LeaveManagementWebApp.Data;
using LeaveManagementWebApp.Models.LeaveTypes;

namespace LeaveManagementWebApp.MappingProfiles;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<LeaveType, IndexVM>();
            // .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<LeaveTypeCreateVM, LeaveType>();
    }
}
