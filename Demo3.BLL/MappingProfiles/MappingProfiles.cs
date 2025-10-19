using AutoMapper;
using Demo3.BLL.DTOs.EmployeeDtos;
using Demo3.DAL.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.MappingProfiles
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dist=>dist.Department,option=>option.MapFrom(src=> src.Department != null ? src.Department.Name : null))
                .ReverseMap();
            //CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDetailsDto>().ReverseMap();
            CreateMap<Employee, CreatedEmployeeDto>().ReverseMap();
            CreateMap<Employee, UpdatedEmployeeDto>().ReverseMap();
        }
    }
}
